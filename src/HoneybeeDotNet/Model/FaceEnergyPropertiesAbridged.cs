/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = HoneybeeDotNet.Client.OpenAPIDateConverter;

namespace HoneybeeDotNet.Model
{
    /// <summary>
    /// FaceEnergyPropertiesAbridged
    /// </summary>
    [DataContract]
    public partial class FaceEnergyPropertiesAbridged :  IEquatable<FaceEnergyPropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="type">type (default to &quot;FaceEnergyPropertiesAbridged&quot;).</param>
        /// <param name="construction">Name of an OpaqueConstruction for the Face. If None, the construction is set by the parent Room construction_set or the Model global_construction_set..</param>
        public FaceEnergyPropertiesAbridged(string type = "FaceEnergyPropertiesAbridged", string construction = default(string))
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "FaceEnergyPropertiesAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.Construction = construction;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Name of an OpaqueConstruction for the Face. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.
        /// </summary>
        /// <value>Name of an OpaqueConstruction for the Face. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.</value>
        [DataMember(Name="construction", EmitDefaultValue=false)]
        [JsonProperty("construction")]
        public string Construction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceEnergyPropertiesAbridged {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Construction: ").Append(Construction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if FaceEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of FaceEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaceEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Construction == input.Construction ||
                    (this.Construction != null &&
                    this.Construction.Equals(input.Construction))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Type (string) pattern
            Regex regexType = new Regex(@"^FaceEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Construction (string) maxLength
            if(this.Construction != null && this.Construction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be less than 100.", new [] { "Construction" });
            }

            // Construction (string) minLength
            if(this.Construction != null && this.Construction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be greater than 1.", new [] { "Construction" });
            }

            yield break;
        }
    }

}
