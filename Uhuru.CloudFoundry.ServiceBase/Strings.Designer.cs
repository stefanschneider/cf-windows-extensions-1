﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uhuru.CloudFoundry.ServiceBase {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Uhuru.CloudFoundry.ServiceBase.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to {0}: Bind request: {1} from {2}.
        /// </summary>
        internal static string BindRequestLogMessage {
            get {
                return ResourceManager.GetString("BindRequestLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Orphan Instances: {0};  Orphan Bindings: {1}.
        /// </summary>
        internal static string CheckOrphanDebugLogMessage {
            get {
                return ResourceManager.GetString("CheckOrphanDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception at OnCheckOrphan {0}.
        /// </summary>
        internal static string CheckOrphanExceptionLogMessage {
            get {
                return ResourceManager.GetString("CheckOrphanExceptionLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: handles for checking orphan.
        /// </summary>
        internal static string CheckOrphanLogMessage {
            get {
                return ResourceManager.GetString("CheckOrphanLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: cleanup nfs request {1} from {2}.
        /// </summary>
        internal static string CleanupNfsLogMessage {
            get {
                return ResourceManager.GetString("CleanupNfsLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Connected to node mbus.
        /// </summary>
        internal static string ConnectedLogMessage {
            get {
                return ResourceManager.GetString("ConnectedLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Initializing.
        /// </summary>
        internal static string InitializingLogMessage {
            get {
                return ResourceManager.GetString("InitializingLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.announce.
        /// </summary>
        internal static string NatsSubjectAnnounce {
            get {
                return ResourceManager.GetString("NatsSubjectAnnounce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.bind.{1}.
        /// </summary>
        internal static string NatsSubjectBind {
            get {
                return ResourceManager.GetString("NatsSubjectBind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.check_orphan.
        /// </summary>
        internal static string NatsSubjectCheckOrphan {
            get {
                return ResourceManager.GetString("NatsSubjectCheckOrphan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.cleanup_nfs.{1}.
        /// </summary>
        internal static string NatsSubjectCleanupNfs {
            get {
                return ResourceManager.GetString("NatsSubjectCleanupNfs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.disable_instance.{1}.
        /// </summary>
        internal static string NatsSubjectDisableInstance {
            get {
                return ResourceManager.GetString("NatsSubjectDisableInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.discover.
        /// </summary>
        internal static string NatsSubjectDiscover {
            get {
                return ResourceManager.GetString("NatsSubjectDiscover", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.enable_instance.{1}.
        /// </summary>
        internal static string NatsSubjectEnableInstance {
            get {
                return ResourceManager.GetString("NatsSubjectEnableInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.import_instance.{1}.
        /// </summary>
        internal static string NatsSubjectImportInstance {
            get {
                return ResourceManager.GetString("NatsSubjectImportInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.orphan_result.
        /// </summary>
        internal static string NatsSubjectOrphanResult {
            get {
                return ResourceManager.GetString("NatsSubjectOrphanResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.provision.{1}.
        /// </summary>
        internal static string NatsSubjectProvision {
            get {
                return ResourceManager.GetString("NatsSubjectProvision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.purge_orphan.{1}.
        /// </summary>
        internal static string NatsSubjectPurgeOrphan {
            get {
                return ResourceManager.GetString("NatsSubjectPurgeOrphan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.restore.{1}.
        /// </summary>
        internal static string NatsSubjectRestore {
            get {
                return ResourceManager.GetString("NatsSubjectRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.unbind.{1}.
        /// </summary>
        internal static string NatsSubjectUnbind {
            get {
                return ResourceManager.GetString("NatsSubjectUnbind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.unprovision.{1}.
        /// </summary>
        internal static string NatsSubjectUnprovision {
            get {
                return ResourceManager.GetString("NatsSubjectUnprovision", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Disable instance {1} request from {2}.
        /// </summary>
        internal static string OnDisableInstanceDebugLogMessage {
            get {
                return ResourceManager.GetString("OnDisableInstanceDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: enable instance {1} request from {2}.
        /// </summary>
        internal static string OnEnableInstanceDebugMessage {
            get {
                return ResourceManager.GetString("OnEnableInstanceDebugMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: import instance {1} request from {2}.
        /// </summary>
        internal static string OnImportInstanceDebugLogMessage {
            get {
                return ResourceManager.GetString("OnImportInstanceDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Provision request: {1} from {2}.
        /// </summary>
        internal static string OnProvisionRequestDebugLogMessage {
            get {
                return ResourceManager.GetString("OnProvisionRequestDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Successfully provisioned service for request {1}: {2}.
        /// </summary>
        internal static string OnProvisionSuccessDebugLogMessage {
            get {
                return ResourceManager.GetString("OnProvisionSuccessDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Message for purging orphan.
        /// </summary>
        internal static string OnPurgeOrphanDebugLogMessage {
            get {
                return ResourceManager.GetString("OnPurgeOrphanDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Restore request: {1} from {2}.
        /// </summary>
        internal static string OnRestoreDebugLogMessage {
            get {
                return ResourceManager.GetString("OnRestoreDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unprovision orphan instance {0} and its bindings {1}.
        /// </summary>
        internal static string PurgeOrphanDebugLogMessage {
            get {
                return ResourceManager.GetString("PurgeOrphanDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error on purge orphan instance {0}: {1}.
        /// </summary>
        internal static string PurgeOrphanErrorLogMessage {
            get {
                return ResourceManager.GetString("PurgeOrphanErrorLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unbind orphan binding {0}.
        /// </summary>
        internal static string PurgeOrphanUnbindBindingDebugLogMessage {
            get {
                return ResourceManager.GetString("PurgeOrphanUnbindBindingDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error on purge orphan binding {0}: {1}.
        /// </summary>
        internal static string PurgeOrphanUnbindBindingErrorLogMessage {
            get {
                return ResourceManager.GetString("PurgeOrphanUnbindBindingErrorLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Sending announcement for {1}.
        /// </summary>
        internal static string SendNodeAnnouncementDebugLogMessage {
            get {
                return ResourceManager.GetString("SendNodeAnnouncementDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Not ready to send announcement.
        /// </summary>
        internal static string SendNodeAnnouncementNotReadyDebugLogMessage {
            get {
                return ResourceManager.GetString("SendNodeAnnouncementNotReadyDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Code: {0}, Error Message: {1}.
        /// </summary>
        internal static string ServiceExceptionAsString {
            get {
                return ResourceManager.GetString("ServiceExceptionAsString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gateway timeout.
        /// </summary>
        internal static string ServiceExceptionGatewayTimeout {
            get {
                return ResourceManager.GetString("ServiceExceptionGatewayTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Error.
        /// </summary>
        internal static string ServiceExceptionInternalError {
            get {
                return ResourceManager.GetString("ServiceExceptionInternalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Content-Type.
        /// </summary>
        internal static string ServiceExceptionInvalidContentType {
            get {
                return ResourceManager.GetString("ServiceExceptionInvalidContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Malformatted request.
        /// </summary>
        internal static string ServiceExceptionMalformedContent {
            get {
                return ResourceManager.GetString("ServiceExceptionMalformedContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not authorized.
        /// </summary>
        internal static string ServiceExceptionNotAuthorized {
            get {
                return ResourceManager.GetString("ServiceExceptionNotAuthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} not found.
        /// </summary>
        internal static string ServiceExceptionNotFound {
            get {
                return ResourceManager.GetString("ServiceExceptionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service unavailable.
        /// </summary>
        internal static string ServiceExceptionServiceUnavailable {
            get {
                return ResourceManager.GetString("ServiceExceptionServiceUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown label.
        /// </summary>
        internal static string ServiceExceptionUnknownLabel {
            get {
                return ResourceManager.GetString("ServiceExceptionUnknownLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Shutting down.
        /// </summary>
        internal static string ShuttingDownLogMessage {
            get {
                return ResourceManager.GetString("ShuttingDownLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Unbind request: {1} from {2}.
        /// </summary>
        internal static string UnbindRequestDebugLogMessage {
            get {
                return ResourceManager.GetString("UnbindRequestDebugLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Unprovision request: {1}..
        /// </summary>
        internal static string UnprovisionRequestDebugLogMessage {
            get {
                return ResourceManager.GetString("UnprovisionRequestDebugLogMessage", resourceCulture);
            }
        }
    }
}
