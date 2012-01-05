﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uhuru.CloudFoundry.MSSqlService {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Uhuru.CloudFoundry.MSSqlService.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error get database list: {0}.
        /// </summary>
        internal static string ErrorGettingDBListErrorMessage {
            get {
                return ResourceManager.GetString("ErrorGettingDBListErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error get tables of {0}, {1}.
        /// </summary>
        internal static string ErrorGettingDBTablesWarningMessage {
            get {
                return ResourceManager.GetString("ErrorGettingDBTablesWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error get instance list: {0}.
        /// </summary>
        internal static string ErrorGettingInstanceListErrorMessage {
            get {
                return ResourceManager.GetString("ErrorGettingInstanceListErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Long transaction killer is disabled..
        /// </summary>
        internal static string LongTXKillerDisabledInfoMessage {
            get {
                return ResourceManager.GetString("LongTXKillerDisabledInfoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bind response: {0}.
        /// </summary>
        internal static string SqlNodeBindResponseDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeBindResponseDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bind service for db:{0}, bind_opts = {1}.
        /// </summary>
        internal static string SqlNodeBindServiceDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeBindServiceDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calculate queries per seconds..
        /// </summary>
        internal static string SqlNodeCalculatingQPSDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeCalculatingQPSDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not delete database: [{0}].
        /// </summary>
        internal static string SqlNodeCannotDeleteDBFatalMessage {
            get {
                return ResourceManager.GetString("SqlNodeCannotDeleteDBFatalMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not delete user &apos;{0}&apos;: [{1}].
        /// </summary>
        internal static string SqlNodeCannotDeleteUserFatalMessage {
            get {
                return ResourceManager.GetString("SqlNodeCannotDeleteUserFatalMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not save entry: {0}.
        /// </summary>
        internal static string SqlNodeCannotSaveProvisionedServicesErrorMessage {
            get {
                return ResourceManager.GetString("SqlNodeCannotSaveProvisionedServicesErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MsSql connection lost: {0}.
        /// </summary>
        internal static string SqlNodeConnectionLostWarningMessage {
            get {
                return ResourceManager.GetString("SqlNodeConnectionLostWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source={0},{1};User Id={2};Password={3};MultipleActiveResultSets=true;Pooling=false.
        /// </summary>
        internal static string SqlNodeConnectionString {
            get {
                return ResourceManager.GetString("SqlNodeConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MsSql connection unrecoverable.
        /// </summary>
        internal static string SqlNodeConnectionUnrecoverableFatalMessage {
            get {
                return ResourceManager.GetString("SqlNodeConnectionUnrecoverableFatalMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create database: [{0}].
        /// </summary>
        internal static string SqlNodeCouldNotCreateDBWarningMessage {
            get {
                return ResourceManager.GetString("SqlNodeCouldNotCreateDBWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating: {0}.
        /// </summary>
        internal static string SqlNodeCreateDatabaseDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeCreateDatabaseDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE DATABASE {0}.
        /// </summary>
        internal static string SqlNodeCreateDatabaseSQL {
            get {
                return ResourceManager.GetString("SqlNodeCreateDatabaseSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE LOGIN {0} WITH PASSWORD = &apos;{1}&apos;.
        /// </summary>
        internal static string SqlNodeCreateLoginSQL {
            get {
                return ResourceManager.GetString("SqlNodeCreateLoginSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE USER {0} FOR LOGIN {0}.
        /// </summary>
        internal static string SqlNodeCreateUserSQL {
            get {
                return ResourceManager.GetString("SqlNodeCreateUserSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating credentials: {0}/{1} for database {2}.
        /// </summary>
        internal static string SqlNodeCreatingCredentialsInfoMessage {
            get {
                return ResourceManager.GetString("SqlNodeCreatingCredentialsInfoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not delete service: {0}.
        /// </summary>
        internal static string SqlNodeDeleteServiceErrorMessage {
            get {
                return ResourceManager.GetString("SqlNodeDeleteServiceErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete user {0}.
        /// </summary>
        internal static string SqlNodeDeleteUserInfoMessage {
            get {
                return ResourceManager.GetString("SqlNodeDeleteUserInfoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting database: {0}.
        /// </summary>
        internal static string SqlNodeDeletingDatabaseInfoMessage {
            get {
                return ResourceManager.GetString("SqlNodeDeletingDatabaseInfoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER LOGIN {0} DISABLE.
        /// </summary>
        internal static string SqlNodeDisableLoginSQL {
            get {
                return ResourceManager.GetString("SqlNodeDisableLoginSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done creating {0}. Took {1} s..
        /// </summary>
        internal static string SqlNodeDoneCreatingDBDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeDoneCreatingDBDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP DATABASE {0}.
        /// </summary>
        internal static string SqlNodeDropDatabaseSQL {
            get {
                return ResourceManager.GetString("SqlNodeDropDatabaseSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP LOGIN {0}.
        /// </summary>
        internal static string SqlNodeDropLoginSQL {
            get {
                return ResourceManager.GetString("SqlNodeDropLoginSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generate varz..
        /// </summary>
        internal static string SqlNodeGenerateVarzDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeGenerateVarzDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error during generate varz: {0}.
        /// </summary>
        internal static string SqlNodeGenerateVarzErrorMessage {
            get {
                return ResourceManager.GetString("SqlNodeGenerateVarzErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT session_id FROM sys.dm_exec_sessions WHERE login_name = &apos;{0}&apos;.
        /// </summary>
        internal static string SqlNodeGetUserSessionsSQL {
            get {
                return ResourceManager.GetString("SqlNodeGetUserSessionsSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select CURRENT_TIMESTAMP.
        /// </summary>
        internal static string SqlNodeKeepAliveSQL {
            get {
                return ResourceManager.GetString("SqlNodeKeepAliveSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KILL {0}.
        /// </summary>
        internal static string SqlNodeKillSessionSQL {
            get {
                return ResourceManager.GetString("SqlNodeKillSessionSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER DATABASE {0} SET OFFLINE WITH ROLLBACK IMMEDIATE.
        /// </summary>
        internal static string SqlNodeTakeDBOfflineSQL {
            get {
                return ResourceManager.GetString("SqlNodeTakeDBOfflineSQL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unbind service: {0}.
        /// </summary>
        internal static string SqlNodeUnbindServiceDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeUnbindServiceDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unprovision database:{0}, bindings: {1}.
        /// </summary>
        internal static string SqlNodeUnprovisionDatabaseDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeUnprovisionDatabaseDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully fulfilled unprovision request: {0}.
        /// </summary>
        internal static string SqlNodeUnprovisionSuccessDebugMessage {
            get {
                return ResourceManager.GetString("SqlNodeUnprovisionSuccessDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MsSql configuration {0} not found..
        /// </summary>
        internal static string SqlServerErrorMessageConfigurationNotFound {
            get {
                return ResourceManager.GetString("SqlServerErrorMessageConfigurationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MsSql credential {0} not found..
        /// </summary>
        internal static string SqlServerErrorMessageCredentialNotFound {
            get {
                return ResourceManager.GetString("SqlServerErrorMessageCredentialNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Node disk is full..
        /// </summary>
        internal static string SqlServerErrorMessageDiskFull {
            get {
                return ResourceManager.GetString("SqlServerErrorMessageDiskFull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid plan {0}..
        /// </summary>
        internal static string SqlServerErrorMessageInvalidPlan {
            get {
                return ResourceManager.GetString("SqlServerErrorMessageInvalidPlan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MsSql node local db error..
        /// </summary>
        internal static string SqlServerErrorMessageLocalDBError {
            get {
                return ResourceManager.GetString("SqlServerErrorMessageLocalDBError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;user: &apos;{0}&apos; name: &apos;{1}&apos; size: {2}&gt;.
        /// </summary>
        internal static string StorageQuotaDbListingFormatString {
            get {
                return ResourceManager.GetString("StorageQuotaDbListingFormatString", resourceCulture);
            }
        }
    }
}
