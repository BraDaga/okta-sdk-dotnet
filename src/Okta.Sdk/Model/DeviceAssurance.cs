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
    /// DeviceAssurance
    /// </summary>
    [DataContract(Name = "DeviceAssurance")]
    
    public partial class DeviceAssurance : IEquatable<DeviceAssurance>
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        
        public Platform Platform { get; set; }
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public string CreatedDate { get; private set; }

        /// <summary>
        /// Returns false as CreatedDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedDate()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DiskEncryptionType
        /// </summary>
        [DataMember(Name = "diskEncryptionType", EmitDefaultValue = false)]
        public DeviceAssuranceDiskEncryptionType DiskEncryptionType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Jailbreak
        /// </summary>
        [DataMember(Name = "jailbreak", EmitDefaultValue = true)]
        public bool Jailbreak { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedBy
        /// </summary>
        [DataMember(Name = "lastUpdatedBy", EmitDefaultValue = false)]
        public string LastUpdatedBy { get; private set; }

        /// <summary>
        /// Returns false as LastUpdatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdatedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name = "lastUpdatedDate", EmitDefaultValue = false)]
        public string LastUpdatedDate { get; private set; }

        /// <summary>
        /// Returns false as LastUpdatedDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdatedDate()
        {
            return false;
        }
        /// <summary>
        /// Display name of the Device Assurance Policy
        /// </summary>
        /// <value>Display name of the Device Assurance Policy</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public VersionObject OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets ScreenLockType
        /// </summary>
        [DataMember(Name = "screenLockType", EmitDefaultValue = false)]
        public DeviceAssuranceScreenLockType ScreenLockType { get; set; }

        /// <summary>
        /// Gets or Sets SecureHardwarePresent
        /// </summary>
        [DataMember(Name = "secureHardwarePresent", EmitDefaultValue = true)]
        public bool SecureHardwarePresent { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public ApiTokenLink Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceAssurance {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  DiskEncryptionType: ").Append(DiskEncryptionType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Jailbreak: ").Append(Jailbreak).Append("\n");
            sb.Append("  LastUpdatedBy: ").Append(LastUpdatedBy).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ScreenLockType: ").Append(ScreenLockType).Append("\n");
            sb.Append("  SecureHardwarePresent: ").Append(SecureHardwarePresent).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as DeviceAssurance);
        }

        /// <summary>
        /// Returns true if DeviceAssurance instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceAssurance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceAssurance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.DiskEncryptionType == input.DiskEncryptionType ||
                    (this.DiskEncryptionType != null &&
                    this.DiskEncryptionType.Equals(input.DiskEncryptionType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Jailbreak == input.Jailbreak ||
                    this.Jailbreak.Equals(input.Jailbreak)
                ) && 
                (
                    this.LastUpdatedBy == input.LastUpdatedBy ||
                    (this.LastUpdatedBy != null &&
                    this.LastUpdatedBy.Equals(input.LastUpdatedBy))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.Platform == input.Platform ||
                    this.Platform.Equals(input.Platform)
                ) && 
                (
                    this.ScreenLockType == input.ScreenLockType ||
                    (this.ScreenLockType != null &&
                    this.ScreenLockType.Equals(input.ScreenLockType))
                ) && 
                (
                    this.SecureHardwarePresent == input.SecureHardwarePresent ||
                    this.SecureHardwarePresent.Equals(input.SecureHardwarePresent)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDate.GetHashCode();
                }
                if (this.DiskEncryptionType != null)
                {
                    hashCode = (hashCode * 59) + this.DiskEncryptionType.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Jailbreak.GetHashCode();
                if (this.LastUpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdatedBy.GetHashCode();
                }
                if (this.LastUpdatedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdatedDate.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                if (this.ScreenLockType != null)
                {
                    hashCode = (hashCode * 59) + this.ScreenLockType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureHardwarePresent.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}