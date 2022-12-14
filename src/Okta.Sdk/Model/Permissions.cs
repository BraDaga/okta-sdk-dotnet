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
    /// Permissions
    /// </summary>
    [DataContract(Name = "Permissions")]
    
    public partial class Permissions : IEquatable<Permissions>
    {
        
        /// <summary>
        /// Gets or Sets _Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<Permission> _Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Permissions {\n");
            sb.Append("  _Permissions: ").Append(_Permissions).Append("\n");
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
            return this.Equals(input as Permissions);
        }

        /// <summary>
        /// Returns true if Permissions instances are equal
        /// </summary>
        /// <param name="input">Instance of Permissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permissions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Permissions == input._Permissions ||
                    this._Permissions != null &&
                    input._Permissions != null &&
                    this._Permissions.SequenceEqual(input._Permissions)
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
                
                if (this._Permissions != null)
                {
                    hashCode = (hashCode * 59) + this._Permissions.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}