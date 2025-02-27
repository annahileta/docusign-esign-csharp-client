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
    /// PrefillTabs
    /// </summary>
    [DataContract]
    public partial class PrefillTabs :  IEquatable<PrefillTabs>, IValidatableObject
    {
        public PrefillTabs()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrefillTabs" /> class.
        /// </summary>
        /// <param name="CheckboxTabs">Specifies a tag on the document in a location where the recipient can select an option..</param>
        /// <param name="DateTabs">Specifies a tab on the document where you want the recipient to enter a date. Date tabs are single-line fields that allow date information to be entered in any format. The tooltip for this tab recommends entering the date as MM/DD/YYYY, but this is not enforced. The format entered by the signer is retained.   If you need a particular date format enforced, DocuSign recommends using a Text tab with a Validation Pattern and Validation Message to enforce the format..</param>
        /// <param name="EmailTabs">Specifies a tag on the document where you want the recipient to enter an email. Email tags are single-line fields that accept any characters. The system checks that a valid email format (i.e. xxx@yyy.zzz) is entered in the tag. It uses the same parameters as a Text tab, with the validation message and pattern set for email information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response..</param>
        /// <param name="NumberTabs">Specifies a tag on the document where you want the recipient to enter a number. It uses the same parameters as a Text tab, with the validation message and pattern set for number information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response. .</param>
        /// <param name="RadioGroupTabs">Specifies a tag on the document in a location where the recipient can select one option from a group of options using a radio button. The radio buttons do not have to be on the same page in a document..</param>
        /// <param name="SenderCompanyTabs">SenderCompanyTabs.</param>
        /// <param name="SenderNameTabs">SenderNameTabs.</param>
        /// <param name="SsnTabs">Specifies a tag on the document where you want the recipient to enter a Social Security Number (SSN). A SSN can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for SSN information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response..</param>
        /// <param name="TabGroups">TabGroups.</param>
        /// <param name="TextTabs">Specifies a that that is an adaptable field that allows the recipient to enter different text information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response..</param>
        /// <param name="ZipTabs">Specifies a tag on the document where you want the recipient to enter a ZIP code. The ZIP code can be a five numbers or the ZIP+4 format with nine numbers. The zip code can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for ZIP code information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response..</param>
        public PrefillTabs(List<Checkbox> CheckboxTabs = default(List<Checkbox>), List<DocuSign.eSign.Model.Date> DateTabs = default(List<DocuSign.eSign.Model.Date>), List<Email> EmailTabs = default(List<Email>), List<Number> NumberTabs = default(List<Number>), List<RadioGroup> RadioGroupTabs = default(List<RadioGroup>), List<SenderCompany> SenderCompanyTabs = default(List<SenderCompany>), List<SenderName> SenderNameTabs = default(List<SenderName>), List<Ssn> SsnTabs = default(List<Ssn>), List<TabGroup> TabGroups = default(List<TabGroup>), List<Text> TextTabs = default(List<Text>), List<Zip> ZipTabs = default(List<Zip>))
        {
            this.CheckboxTabs = CheckboxTabs;
            this.DateTabs = DateTabs;
            this.EmailTabs = EmailTabs;
            this.NumberTabs = NumberTabs;
            this.RadioGroupTabs = RadioGroupTabs;
            this.SenderCompanyTabs = SenderCompanyTabs;
            this.SenderNameTabs = SenderNameTabs;
            this.SsnTabs = SsnTabs;
            this.TabGroups = TabGroups;
            this.TextTabs = TextTabs;
            this.ZipTabs = ZipTabs;
        }
        
        /// <summary>
        /// Specifies a tag on the document in a location where the recipient can select an option.
        /// </summary>
        /// <value>Specifies a tag on the document in a location where the recipient can select an option.</value>
        [DataMember(Name="checkboxTabs", EmitDefaultValue=false)]
        public List<Checkbox> CheckboxTabs { get; set; }
        /// <summary>
        /// Specifies a tab on the document where you want the recipient to enter a date. Date tabs are single-line fields that allow date information to be entered in any format. The tooltip for this tab recommends entering the date as MM/DD/YYYY, but this is not enforced. The format entered by the signer is retained.   If you need a particular date format enforced, DocuSign recommends using a Text tab with a Validation Pattern and Validation Message to enforce the format.
        /// </summary>
        /// <value>Specifies a tab on the document where you want the recipient to enter a date. Date tabs are single-line fields that allow date information to be entered in any format. The tooltip for this tab recommends entering the date as MM/DD/YYYY, but this is not enforced. The format entered by the signer is retained.   If you need a particular date format enforced, DocuSign recommends using a Text tab with a Validation Pattern and Validation Message to enforce the format.</value>
        [DataMember(Name="dateTabs", EmitDefaultValue=false)]
        public List<DocuSign.eSign.Model.Date> DateTabs { get; set; }
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter an email. Email tags are single-line fields that accept any characters. The system checks that a valid email format (i.e. xxx@yyy.zzz) is entered in the tag. It uses the same parameters as a Text tab, with the validation message and pattern set for email information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter an email. Email tags are single-line fields that accept any characters. The system checks that a valid email format (i.e. xxx@yyy.zzz) is entered in the tag. It uses the same parameters as a Text tab, with the validation message and pattern set for email information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="emailTabs", EmitDefaultValue=false)]
        public List<Email> EmailTabs { get; set; }
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter a number. It uses the same parameters as a Text tab, with the validation message and pattern set for number information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response. 
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter a number. It uses the same parameters as a Text tab, with the validation message and pattern set for number information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response. </value>
        [DataMember(Name="numberTabs", EmitDefaultValue=false)]
        public List<Number> NumberTabs { get; set; }
        /// <summary>
        /// Specifies a tag on the document in a location where the recipient can select one option from a group of options using a radio button. The radio buttons do not have to be on the same page in a document.
        /// </summary>
        /// <value>Specifies a tag on the document in a location where the recipient can select one option from a group of options using a radio button. The radio buttons do not have to be on the same page in a document.</value>
        [DataMember(Name="radioGroupTabs", EmitDefaultValue=false)]
        public List<RadioGroup> RadioGroupTabs { get; set; }
        /// <summary>
        /// Gets or Sets SenderCompanyTabs
        /// </summary>
        [DataMember(Name="senderCompanyTabs", EmitDefaultValue=false)]
        public List<SenderCompany> SenderCompanyTabs { get; set; }
        /// <summary>
        /// Gets or Sets SenderNameTabs
        /// </summary>
        [DataMember(Name="senderNameTabs", EmitDefaultValue=false)]
        public List<SenderName> SenderNameTabs { get; set; }
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter a Social Security Number (SSN). A SSN can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for SSN information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter a Social Security Number (SSN). A SSN can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for SSN information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="ssnTabs", EmitDefaultValue=false)]
        public List<Ssn> SsnTabs { get; set; }
        /// <summary>
        /// Gets or Sets TabGroups
        /// </summary>
        [DataMember(Name="tabGroups", EmitDefaultValue=false)]
        public List<TabGroup> TabGroups { get; set; }
        /// <summary>
        /// Specifies a that that is an adaptable field that allows the recipient to enter different text information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a that that is an adaptable field that allows the recipient to enter different text information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="textTabs", EmitDefaultValue=false)]
        public List<Text> TextTabs { get; set; }
        /// <summary>
        /// Specifies a tag on the document where you want the recipient to enter a ZIP code. The ZIP code can be a five numbers or the ZIP+4 format with nine numbers. The zip code can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for ZIP code information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.
        /// </summary>
        /// <value>Specifies a tag on the document where you want the recipient to enter a ZIP code. The ZIP code can be a five numbers or the ZIP+4 format with nine numbers. The zip code can be typed with or without dashes. It uses the same parameters as a Text tab, with the validation message and pattern set for ZIP code information.  When getting information that includes this tab type, the original value of the tab when the associated envelope was sent is included in the response.</value>
        [DataMember(Name="zipTabs", EmitDefaultValue=false)]
        public List<Zip> ZipTabs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrefillTabs {\n");
            sb.Append("  CheckboxTabs: ").Append(CheckboxTabs).Append("\n");
            sb.Append("  DateTabs: ").Append(DateTabs).Append("\n");
            sb.Append("  EmailTabs: ").Append(EmailTabs).Append("\n");
            sb.Append("  NumberTabs: ").Append(NumberTabs).Append("\n");
            sb.Append("  RadioGroupTabs: ").Append(RadioGroupTabs).Append("\n");
            sb.Append("  SenderCompanyTabs: ").Append(SenderCompanyTabs).Append("\n");
            sb.Append("  SenderNameTabs: ").Append(SenderNameTabs).Append("\n");
            sb.Append("  SsnTabs: ").Append(SsnTabs).Append("\n");
            sb.Append("  TabGroups: ").Append(TabGroups).Append("\n");
            sb.Append("  TextTabs: ").Append(TextTabs).Append("\n");
            sb.Append("  ZipTabs: ").Append(ZipTabs).Append("\n");
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
            return this.Equals(obj as PrefillTabs);
        }

        /// <summary>
        /// Returns true if PrefillTabs instances are equal
        /// </summary>
        /// <param name="other">Instance of PrefillTabs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrefillTabs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CheckboxTabs == other.CheckboxTabs ||
                    this.CheckboxTabs != null &&
                    this.CheckboxTabs.SequenceEqual(other.CheckboxTabs)
                ) && 
                (
                    this.DateTabs == other.DateTabs ||
                    this.DateTabs != null &&
                    this.DateTabs.SequenceEqual(other.DateTabs)
                ) && 
                (
                    this.EmailTabs == other.EmailTabs ||
                    this.EmailTabs != null &&
                    this.EmailTabs.SequenceEqual(other.EmailTabs)
                ) && 
                (
                    this.NumberTabs == other.NumberTabs ||
                    this.NumberTabs != null &&
                    this.NumberTabs.SequenceEqual(other.NumberTabs)
                ) && 
                (
                    this.RadioGroupTabs == other.RadioGroupTabs ||
                    this.RadioGroupTabs != null &&
                    this.RadioGroupTabs.SequenceEqual(other.RadioGroupTabs)
                ) && 
                (
                    this.SenderCompanyTabs == other.SenderCompanyTabs ||
                    this.SenderCompanyTabs != null &&
                    this.SenderCompanyTabs.SequenceEqual(other.SenderCompanyTabs)
                ) && 
                (
                    this.SenderNameTabs == other.SenderNameTabs ||
                    this.SenderNameTabs != null &&
                    this.SenderNameTabs.SequenceEqual(other.SenderNameTabs)
                ) && 
                (
                    this.SsnTabs == other.SsnTabs ||
                    this.SsnTabs != null &&
                    this.SsnTabs.SequenceEqual(other.SsnTabs)
                ) && 
                (
                    this.TabGroups == other.TabGroups ||
                    this.TabGroups != null &&
                    this.TabGroups.SequenceEqual(other.TabGroups)
                ) && 
                (
                    this.TextTabs == other.TextTabs ||
                    this.TextTabs != null &&
                    this.TextTabs.SequenceEqual(other.TextTabs)
                ) && 
                (
                    this.ZipTabs == other.ZipTabs ||
                    this.ZipTabs != null &&
                    this.ZipTabs.SequenceEqual(other.ZipTabs)
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
                if (this.CheckboxTabs != null)
                    hash = hash * 59 + this.CheckboxTabs.GetHashCode();
                if (this.DateTabs != null)
                    hash = hash * 59 + this.DateTabs.GetHashCode();
                if (this.EmailTabs != null)
                    hash = hash * 59 + this.EmailTabs.GetHashCode();
                if (this.NumberTabs != null)
                    hash = hash * 59 + this.NumberTabs.GetHashCode();
                if (this.RadioGroupTabs != null)
                    hash = hash * 59 + this.RadioGroupTabs.GetHashCode();
                if (this.SenderCompanyTabs != null)
                    hash = hash * 59 + this.SenderCompanyTabs.GetHashCode();
                if (this.SenderNameTabs != null)
                    hash = hash * 59 + this.SenderNameTabs.GetHashCode();
                if (this.SsnTabs != null)
                    hash = hash * 59 + this.SsnTabs.GetHashCode();
                if (this.TabGroups != null)
                    hash = hash * 59 + this.TabGroups.GetHashCode();
                if (this.TextTabs != null)
                    hash = hash * 59 + this.TextTabs.GetHashCode();
                if (this.ZipTabs != null)
                    hash = hash * 59 + this.ZipTabs.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
