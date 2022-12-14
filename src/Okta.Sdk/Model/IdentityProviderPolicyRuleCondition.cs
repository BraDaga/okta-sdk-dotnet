/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// IdentityProviderPolicyRuleCondition
    /// </summary>
    [DataContract(Name = "IdentityProviderPolicyRuleCondition")]
    
    public partial class IdentityProviderPolicyRuleCondition : IEquatable<IdentityProviderPolicyRuleCondition>
    {

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        
        public IdentityProviderPolicyProvider Provider { get; set; }
        
        /// <summary>
        /// Gets or Sets IdpIds
        /// </summary>
        [DataMember(Name = "idpIds", EmitDefaultValue = false)]
        public List<string> IdpIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdentityProviderPolicyRuleCondition {\n");
            sb.Append("  IdpIds: ").Append(IdpIds).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityProviderPolicyRuleCondition);
        }

        /// <summary>
        /// Returns true if IdentityProviderPolicyRuleCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityProviderPolicyRuleCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProviderPolicyRuleCondition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IdpIds == input.IdpIds ||
                    this.IdpIds != null &&
                    input.IdpIds != null &&
                    this.IdpIds.SequenceEqual(input.IdpIds)
                ) && 
                (
                    this.Provider == input.Provider ||
                    this.Provider.Equals(input.Provider)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                
                if (this.IdpIds != null)
                {
                    hashCode = (hashCode * 59) + this.IdpIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                return hashCode;
            }
        }

    }

}