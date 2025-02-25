// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// Non versioned Container App configuration properties that define the mutable settings of a Container app
    /// </summary>
    public partial class Configuration
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject into a new instance of <see cref="Configuration" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Configuration(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_ingress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("ingress"), out var __jsonIngress) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Ingress.FromJson(__jsonIngress) : _ingress;}
            {_dapr = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("dapr"), out var __jsonDapr) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Dapr.FromJson(__jsonDapr) : _dapr;}
            {_service = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject>("service"), out var __jsonService) ? Microsoft.Azure.PowerShell.Cmdlets.App.Models.Service.FromJson(__jsonService) : _service;}
            {_secret = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray>("secrets"), out var __jsonSecrets) ? If( __jsonSecrets as Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.ISecret>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.App.Models.ISecret) (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Secret.FromJson(__u) )) ))() : null : _secret;}
            {_activeRevisionsMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString>("activeRevisionsMode"), out var __jsonActiveRevisionsMode) ? (string)__jsonActiveRevisionsMode : (string)_activeRevisionsMode;}
            {_registry = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray>("registries"), out var __jsonRegistries) ? If( __jsonRegistries as Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IRegistryCredentials>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.App.Models.IRegistryCredentials) (Microsoft.Azure.PowerShell.Cmdlets.App.Models.RegistryCredentials.FromJson(__p) )) ))() : null : _registry;}
            {_maxInactiveRevision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNumber>("maxInactiveRevisions"), out var __jsonMaxInactiveRevisions) ? (int?)__jsonMaxInactiveRevisions : _maxInactiveRevision;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IConfiguration.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.App.Models.IConfiguration.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IConfiguration FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject json ? new Configuration(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="Configuration" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Configuration" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._ingress ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._ingress.ToJson(null,serializationMode) : null, "ingress" ,container.Add );
            AddIf( null != this._dapr ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._dapr.ToJson(null,serializationMode) : null, "dapr" ,container.Add );
            AddIf( null != this._service ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) this._service.ToJson(null,serializationMode) : null, "service" ,container.Add );
            if (null != this._secret)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.XNodeArray();
                foreach( var __x in this._secret )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("secrets",__w);
            }
            AddIf( null != (((object)this._activeRevisionsMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonString(this._activeRevisionsMode.ToString()) : null, "activeRevisionsMode" ,container.Add );
            if (null != this._registry)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.XNodeArray();
                foreach( var __s in this._registry )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("registries",__r);
            }
            AddIf( null != this._maxInactiveRevision ? (Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNumber((int)this._maxInactiveRevision) : null, "maxInactiveRevisions" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}