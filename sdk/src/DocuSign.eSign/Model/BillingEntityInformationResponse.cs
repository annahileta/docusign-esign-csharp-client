/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// BillingEntityInformationResponse
    /// </summary>
    [DataContract]
    public partial class BillingEntityInformationResponse :  IEquatable<BillingEntityInformationResponse>, IValidatableObject
    {
        public BillingEntityInformationResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingEntityInformationResponse" /> class.
        /// </summary>
        /// <param name="BillingProfile">BillingProfile.</param>
        /// <param name="EntityName">EntityName.</param>
        /// <param name="ExternalEntityId">ExternalEntityId.</param>
        /// <param name="IsExternallyBilled">IsExternallyBilled.</param>
        public BillingEntityInformationResponse(string BillingProfile = default(string), string EntityName = default(string), string ExternalEntityId = default(string), string IsExternallyBilled = default(string))
        {
            this.BillingProfile = BillingProfile;
            this.EntityName = EntityName;
            this.ExternalEntityId = ExternalEntityId;
            this.IsExternallyBilled = IsExternallyBilled;
        }
        
        /// <summary>
        /// Gets or Sets BillingProfile
        /// </summary>
        [DataMember(Name="billingProfile", EmitDefaultValue=false)]
        public string BillingProfile { get; set; }
        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }
        /// <summary>
        /// Gets or Sets ExternalEntityId
        /// </summary>
        [DataMember(Name="externalEntityId", EmitDefaultValue=false)]
        public string ExternalEntityId { get; set; }
        /// <summary>
        /// Gets or Sets IsExternallyBilled
        /// </summary>
        [DataMember(Name="isExternallyBilled", EmitDefaultValue=false)]
        public string IsExternallyBilled { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingEntityInformationResponse {\n");
            sb.Append("  BillingProfile: ").Append(BillingProfile).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  ExternalEntityId: ").Append(ExternalEntityId).Append("\n");
            sb.Append("  IsExternallyBilled: ").Append(IsExternallyBilled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BillingEntityInformationResponse);
        }

        /// <summary>
        /// Returns true if BillingEntityInformationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingEntityInformationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingEntityInformationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BillingProfile == other.BillingProfile ||
                    this.BillingProfile != null &&
                    this.BillingProfile.Equals(other.BillingProfile)
                ) && 
                (
                    this.EntityName == other.EntityName ||
                    this.EntityName != null &&
                    this.EntityName.Equals(other.EntityName)
                ) && 
                (
                    this.ExternalEntityId == other.ExternalEntityId ||
                    this.ExternalEntityId != null &&
                    this.ExternalEntityId.Equals(other.ExternalEntityId)
                ) && 
                (
                    this.IsExternallyBilled == other.IsExternallyBilled ||
                    this.IsExternallyBilled != null &&
                    this.IsExternallyBilled.Equals(other.IsExternallyBilled)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.BillingProfile != null)
                    hash = hash * 59 + this.BillingProfile.GetHashCode();
                if (this.EntityName != null)
                    hash = hash * 59 + this.EntityName.GetHashCode();
                if (this.ExternalEntityId != null)
                    hash = hash * 59 + this.ExternalEntityId.GetHashCode();
                if (this.IsExternallyBilled != null)
                    hash = hash * 59 + this.IsExternallyBilled.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
