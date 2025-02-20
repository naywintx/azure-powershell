// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Extensions;

    public partial class NginxDeploymentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal
    {

        /// <summary>Backing field for <see cref="EnableDiagnosticsSupport" /> property.</summary>
        private bool? _enableDiagnosticsSupport;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public bool? EnableDiagnosticsSupport { get => this._enableDiagnosticsSupport; set => this._enableDiagnosticsSupport = value; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>The IP address of the deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; }

        /// <summary>Backing field for <see cref="Logging" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging _logging;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging Logging { get => (this._logging = this._logging ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxLogging()); set => this._logging = value; }

        /// <summary>Backing field for <see cref="ManagedResourceGroup" /> property.</summary>
        private string _managedResourceGroup;

        /// <summary>The managed resource group to deploy VNet injection related network resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string ManagedResourceGroup { get => this._managedResourceGroup; set => this._managedResourceGroup = value; }

        /// <summary>Internal Acessors for IPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal.IPAddress { get => this._iPAddress; set { {_iPAddress = value;} } }

        /// <summary>Internal Acessors for Logging</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal.Logging { get => (this._logging = this._logging ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxLogging()); set { {_logging = value;} } }

        /// <summary>Internal Acessors for LoggingStorageAccount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxStorageAccount Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal.LoggingStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLoggingInternal)Logging).StorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLoggingInternal)Logging).StorageAccount = value; }

        /// <summary>Internal Acessors for NginxVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal.NginxVersion { get => this._nginxVersion; set { {_nginxVersion = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ScalingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal.ScalingProperty { get => (this._scalingProperty = this._scalingProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentScalingProperties()); set { {_scalingProperty = value;} } }

        /// <summary>Internal Acessors for UserProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentPropertiesInternal.UserProfile { get => (this._userProfile = this._userProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUserProfile()); set { {_userProfile = value;} } }

        /// <summary>Backing field for <see cref="NetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxNetworkProfile _networkProfile;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxNetworkProfile NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxNetworkProfile()); set => this._networkProfile = value; }

        /// <summary>Backing field for <see cref="NginxVersion" /> property.</summary>
        private string _nginxVersion;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public string NginxVersion { get => this._nginxVersion; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.ProvisioningState? _provisioningState;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ScalingProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties _scalingProperty;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties ScalingProperty { get => (this._scalingProperty = this._scalingProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentScalingProperties()); set => this._scalingProperty = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public int? ScalingPropertyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingPropertiesInternal)ScalingProperty).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingPropertiesInternal)ScalingProperty).Capacity = value ?? default(int); }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string StorageAccountContainerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLoggingInternal)Logging).StorageAccountContainerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLoggingInternal)Logging).StorageAccountContainerName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string StorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLoggingInternal)Logging).StorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLoggingInternal)Logging).StorageAccountName = value ?? null; }

        /// <summary>Backing field for <see cref="UserProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile _userProfile;

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile UserProfile { get => (this._userProfile = this._userProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.NginxDeploymentUserProfile()); set => this._userProfile = value; }

        /// <summary>
        /// The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string
        /// or a valid email address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Origin(Microsoft.Azure.PowerShell.Cmdlets.Nginx.PropertyOrigin.Inlined)]
        public string UserProfilePreferredEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfileInternal)UserProfile).PreferredEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfileInternal)UserProfile).PreferredEmail = value ?? null; }

        /// <summary>Creates an new <see cref="NginxDeploymentProperties" /> instance.</summary>
        public NginxDeploymentProperties()
        {

        }
    }
    public partial interface INginxDeploymentProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"enableDiagnosticsSupport",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableDiagnosticsSupport { get; set; }
        /// <summary>The IP address of the deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The IP address of the deployment.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get;  }
        /// <summary>The managed resource group to deploy VNet injection related network resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The managed resource group to deploy VNet injection related network resources.",
        SerializedName = @"managedResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroup { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"networkProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxNetworkProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxNetworkProfile NetworkProfile { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"nginxVersion",
        PossibleTypes = new [] { typeof(string) })]
        string NginxVersion { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.ProvisioningState? ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? ScalingPropertyCapacity { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountContainerName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountName { get; set; }
        /// <summary>
        /// The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string
        /// or a valid email address.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Nginx.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string or a valid email address.",
        SerializedName = @"preferredEmail",
        PossibleTypes = new [] { typeof(string) })]
        string UserProfilePreferredEmail { get; set; }

    }
    internal partial interface INginxDeploymentPropertiesInternal

    {
        bool? EnableDiagnosticsSupport { get; set; }
        /// <summary>The IP address of the deployment.</summary>
        string IPAddress { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxLogging Logging { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxStorageAccount LoggingStorageAccount { get; set; }
        /// <summary>The managed resource group to deploy VNet injection related network resources.</summary>
        string ManagedResourceGroup { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxNetworkProfile NetworkProfile { get; set; }

        string NginxVersion { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Support.ProvisioningState? ProvisioningState { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentScalingProperties ScalingProperty { get; set; }

        int? ScalingPropertyCapacity { get; set; }

        string StorageAccountContainerName { get; set; }

        string StorageAccountName { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Nginx.Models.Api20230401.INginxDeploymentUserProfile UserProfile { get; set; }
        /// <summary>
        /// The preferred support contact email address of the user used for sending alerts and notification. Can be an empty string
        /// or a valid email address.
        /// </summary>
        string UserProfilePreferredEmail { get; set; }

    }
}