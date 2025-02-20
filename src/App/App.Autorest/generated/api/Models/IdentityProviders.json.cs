// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// The configuration settings of each of the identity providers used to configure ContainerApp Service Authentication/Authorization.
    /// </summary>
    public partial class IdentityProviders
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIdentityProviders.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIdentityProviders.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IIdentityProviders FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json ? new IdentityProviders(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject into a new instance of <see cref="IdentityProviders" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal IdentityProviders(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_azureActiveDirectory = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("azureActiveDirectory"), out var __jsonAzureActiveDirectory) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.AzureActiveDirectory.FromJson(__jsonAzureActiveDirectory) : _azureActiveDirectory;}
            {_facebook = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("facebook"), out var __jsonFacebook) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Facebook.FromJson(__jsonFacebook) : _facebook;}
            {_gitHub = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("gitHub"), out var __jsonGitHub) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.GitHub.FromJson(__jsonGitHub) : _gitHub;}
            {_google = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("google"), out var __jsonGoogle) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Google.FromJson(__jsonGoogle) : _google;}
            {_twitter = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("twitter"), out var __jsonTwitter) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Twitter.FromJson(__jsonTwitter) : _twitter;}
            {_apple = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("apple"), out var __jsonApple) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Apple.FromJson(__jsonApple) : _apple;}
            {_azureStaticWebApp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("azureStaticWebApps"), out var __jsonAzureStaticWebApps) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.AzureStaticWebApps.FromJson(__jsonAzureStaticWebApps) : _azureStaticWebApp;}
            {_customOpenIdConnectProvider = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("customOpenIdConnectProviders"), out var __jsonCustomOpenIdConnectProviders) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.IdentityProvidersCustomOpenIdConnectProviders.FromJson(__jsonCustomOpenIdConnectProviders) : _customOpenIdConnectProvider;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="IdentityProviders" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="IdentityProviders" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._azureActiveDirectory ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._azureActiveDirectory.ToJson(null,serializationMode) : null, "azureActiveDirectory" ,container.Add );
            AddIf( null != this._facebook ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._facebook.ToJson(null,serializationMode) : null, "facebook" ,container.Add );
            AddIf( null != this._gitHub ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._gitHub.ToJson(null,serializationMode) : null, "gitHub" ,container.Add );
            AddIf( null != this._google ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._google.ToJson(null,serializationMode) : null, "google" ,container.Add );
            AddIf( null != this._twitter ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._twitter.ToJson(null,serializationMode) : null, "twitter" ,container.Add );
            AddIf( null != this._apple ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._apple.ToJson(null,serializationMode) : null, "apple" ,container.Add );
            AddIf( null != this._azureStaticWebApp ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._azureStaticWebApp.ToJson(null,serializationMode) : null, "azureStaticWebApps" ,container.Add );
            AddIf( null != this._customOpenIdConnectProvider ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._customOpenIdConnectProvider.ToJson(null,serializationMode) : null, "customOpenIdConnectProviders" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}