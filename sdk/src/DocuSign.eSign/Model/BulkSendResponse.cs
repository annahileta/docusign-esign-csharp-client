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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// BulkSendResponse
    /// </summary>
    [DataContract]
    public partial class BulkSendResponse :  IEquatable<BulkSendResponse>, IValidatableObject
    {
        public BulkSendResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendResponse" /> class.
        /// </summary>
        /// <param name="BatchId">.</param>
        /// <param name="EnvelopeOrTemplateId">.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Errors">.</param>
        public BulkSendResponse(string BatchId = default(string), string EnvelopeOrTemplateId = default(string), List<string> ErrorDetails = default(List<string>), List<string> Errors = default(List<string>))
        {
            this.BatchId = BatchId;
            this.EnvelopeOrTemplateId = EnvelopeOrTemplateId;
            this.ErrorDetails = ErrorDetails;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeOrTemplateId", EmitDefaultValue=false)]
        public string EnvelopeOrTemplateId { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public List<string> ErrorDetails { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendResponse {\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  EnvelopeOrTemplateId: ").Append(EnvelopeOrTemplateId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(obj as BulkSendResponse);
        }

        /// <summary>
        /// Returns true if BulkSendResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BatchId == other.BatchId ||
                    this.BatchId != null &&
                    this.BatchId.Equals(other.BatchId)
                ) && 
                (
                    this.EnvelopeOrTemplateId == other.EnvelopeOrTemplateId ||
                    this.EnvelopeOrTemplateId != null &&
                    this.EnvelopeOrTemplateId.Equals(other.EnvelopeOrTemplateId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(other.ErrorDetails)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
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
                if (this.BatchId != null)
                    hash = hash * 59 + this.BatchId.GetHashCode();
                if (this.EnvelopeOrTemplateId != null)
                    hash = hash * 59 + this.EnvelopeOrTemplateId.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
