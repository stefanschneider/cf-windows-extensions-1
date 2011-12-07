﻿// -----------------------------------------------------------------------
// <copyright file="WindowsVcapUsers.cs" company="Uhuru Software">
// Copyright (c) 2011 Uhuru Software, Inc., All Rights Reserved
// </copyright>
// -----------------------------------------------------------------------

namespace Uhuru.Utilities
{
    using System;
    using System.DirectoryServices;
    
    /// <summary>
    /// This is a helper class for creating Windows Users.
    /// </summary>
    public static class WindowsVcapUsers
    {
        /// <summary>
        /// Creates a user based on an id. The created user has a random string added to it, and a specific prefix.
        /// </summary>
        /// <param name="id">An id for the username.</param>
        /// <param name="password">A password for the user. Make sure it's strong.</param>
        /// <returns>The final username of the newly created Windows User.</returns>
        public static string CreateUser(string id, string password)
        {
            if (password == null)
            {
                password = Utilities.Credentials.GenerateCredential();
            }

            string decoratedUsername = DecorateUser(id);
            using (DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName.ToString()))
            {
                DirectoryEntries entries = directoryEntry.Children;
                DirectoryEntry user = entries.Add(decoratedUsername, "User");
                user.Properties["FullName"].Add("Uhuru Vcap Instance " + id + " user");
                user.Invoke("SetPassword", password);
                user.CommitChanges();
            }

            return decoratedUsername;
        }

        /// <summary>
        /// Deletes a windows user based on an Id.
        /// </summary>
        /// <param name="id">The id that was used to create the user.</param>
        public static void DeleteUser(string id)
        {
            string decoratedUsername = DecorateUser(id);
            using (DirectoryEntry localDirectory = new DirectoryEntry("WinNT://" + Environment.MachineName.ToString()))
            {
                DirectoryEntries users = localDirectory.Children;
                DirectoryEntry user = users.Find(decoratedUsername);
                users.Remove(user);
            }
        }

        private static string DecorateUser(string id)
        {
            return "UhuruVc4p" + id.Substring(0, Math.Min(10, id.Length));
        }
    }
}
