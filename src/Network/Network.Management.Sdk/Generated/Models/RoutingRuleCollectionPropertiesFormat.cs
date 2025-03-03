// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Defines the routing rule collection properties.
    /// </summary>
    public partial class RoutingRuleCollectionPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the RoutingRuleCollectionPropertiesFormat class.
        /// </summary>
        public RoutingRuleCollectionPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoutingRuleCollectionPropertiesFormat class.
        /// </summary>

        /// <param name="description">A description of the routing rule collection.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="resourceGuid">Unique identifier for this resource.
        /// </param>

        /// <param name="appliesTo">Groups for configuration
        /// </param>

        /// <param name="disableBgpRoutePropagation">Determines whether BGP route propagation is enabled. Defaults to true.
        /// Possible values include: &#39;False&#39;, &#39;True&#39;</param>
        public RoutingRuleCollectionPropertiesFormat(System.Collections.Generic.IList<NetworkManagerRoutingGroupItem> appliesTo, string description = default(string), string provisioningState = default(string), string resourceGuid = default(string), string disableBgpRoutePropagation = default(string))

        {
            this.Description = description;
            this.ProvisioningState = provisioningState;
            this.ResourceGuid = resourceGuid;
            this.AppliesTo = appliesTo;
            this.DisableBgpRoutePropagation = disableBgpRoutePropagation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets a description of the routing rule collection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets unique identifier for this resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceGuid")]
        public string ResourceGuid {get; private set; }

        /// <summary>
        /// Gets or sets groups for configuration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "appliesTo")]
        public System.Collections.Generic.IList<NetworkManagerRoutingGroupItem> AppliesTo {get; set; }

        /// <summary>
        /// Gets or sets determines whether BGP route propagation is enabled. Defaults
        /// to true. Possible values include: &#39;False&#39;, &#39;True&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disableBgpRoutePropagation")]
        public string DisableBgpRoutePropagation {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.AppliesTo == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AppliesTo");
            }



            if (this.AppliesTo != null)
            {
                foreach (var element in this.AppliesTo)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }

        }
    }
}