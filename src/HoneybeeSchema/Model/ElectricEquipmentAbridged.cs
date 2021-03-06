/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.17.0
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


namespace HoneybeeSchema
{
    /// <summary>
    /// Base class for all objects requiring a valid EnergyPlus name.
    /// </summary>
    [DataContract]
    public partial class ElectricEquipmentAbridged :  IEquatable<ElectricEquipmentAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipmentAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElectricEquipmentAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipmentAbridged" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="wattsPerArea">Equipment level per floor area as [W/m2]. (required).</param>
        /// <param name="schedule">Name of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile. (required).</param>
        /// <param name="radiantFraction">Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0. (default to 0).</param>
        /// <param name="latentFraction">Number for the amount of latent heat given off by electricequipment. Default value is 0. (default to 0).</param>
        /// <param name="lostFraction">Number for the amount of “lost” heat being given off by equipment. The default value is 0. (default to 0).</param>
        /// <param name="type">type (default to &quot;ElectricEquipmentAbridged&quot;).</param>
        public ElectricEquipmentAbridged(string name, double wattsPerArea, string schedule, double radiantFraction = 0, double latentFraction = 0, double lostFraction = 0, string type = "ElectricEquipmentAbridged")
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ElectricEquipmentAbridged and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "wattsPerArea" is required (not null)
            if (wattsPerArea == null)
            {
                throw new InvalidDataException("wattsPerArea is a required property for ElectricEquipmentAbridged and cannot be null");
            }
            else
            {
                this.WattsPerArea = wattsPerArea;
            }
            
            // to ensure "schedule" is required (not null)
            if (schedule == null)
            {
                throw new InvalidDataException("schedule is a required property for ElectricEquipmentAbridged and cannot be null");
            }
            else
            {
                this.Schedule = schedule;
            }
            
            // use default value if no "radiantFraction" provided
            if (radiantFraction == null)
            {
                this.RadiantFraction = 0;
            }
            else
            {
                this.RadiantFraction = radiantFraction;
            }
            // use default value if no "latentFraction" provided
            if (latentFraction == null)
            {
                this.LatentFraction = 0;
            }
            else
            {
                this.LatentFraction = latentFraction;
            }
            // use default value if no "lostFraction" provided
            if (lostFraction == null)
            {
                this.LostFraction = 0;
            }
            else
            {
                this.LostFraction = lostFraction;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ElectricEquipmentAbridged";
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Equipment level per floor area as [W/m2].
        /// </summary>
        /// <value>Equipment level per floor area as [W/m2].</value>
        [DataMember(Name="watts_per_area", EmitDefaultValue=false)]
        [JsonProperty("watts_per_area")]
        public double WattsPerArea { get; set; }

        /// <summary>
        /// Name of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.
        /// </summary>
        /// <value>Name of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.</value>
        [DataMember(Name="radiant_fraction", EmitDefaultValue=false)]
        [JsonProperty("radiant_fraction")]
        public double RadiantFraction { get; set; }

        /// <summary>
        /// Number for the amount of latent heat given off by electricequipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of latent heat given off by electricequipment. Default value is 0.</value>
        [DataMember(Name="latent_fraction", EmitDefaultValue=false)]
        [JsonProperty("latent_fraction")]
        public double LatentFraction { get; set; }

        /// <summary>
        /// Number for the amount of “lost” heat being given off by equipment. The default value is 0.
        /// </summary>
        /// <value>Number for the amount of “lost” heat being given off by equipment. The default value is 0.</value>
        [DataMember(Name="lost_fraction", EmitDefaultValue=false)]
        [JsonProperty("lost_fraction")]
        public double LostFraction { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectricEquipmentAbridged {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WattsPerArea: ").Append(WattsPerArea).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  RadiantFraction: ").Append(RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(LatentFraction).Append("\n");
            sb.Append("  LostFraction: ").Append(LostFraction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ElectricEquipmentAbridged object</returns>
        public static ElectricEquipmentAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ElectricEquipmentAbridged>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ElectricEquipmentAbridged);
        }

        /// <summary>
        /// Returns true if ElectricEquipmentAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectricEquipmentAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectricEquipmentAbridged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.WattsPerArea == input.WattsPerArea ||
                    (this.WattsPerArea != null &&
                    this.WattsPerArea.Equals(input.WattsPerArea))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.RadiantFraction == input.RadiantFraction ||
                    (this.RadiantFraction != null &&
                    this.RadiantFraction.Equals(input.RadiantFraction))
                ) && 
                (
                    this.LatentFraction == input.LatentFraction ||
                    (this.LatentFraction != null &&
                    this.LatentFraction.Equals(input.LatentFraction))
                ) && 
                (
                    this.LostFraction == input.LostFraction ||
                    (this.LostFraction != null &&
                    this.LostFraction.Equals(input.LostFraction))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.WattsPerArea != null)
                    hashCode = hashCode * 59 + this.WattsPerArea.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.LatentFraction != null)
                    hashCode = hashCode * 59 + this.LatentFraction.GetHashCode();
                if (this.LostFraction != null)
                    hashCode = hashCode * 59 + this.LostFraction.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // WattsPerArea (double) minimum
            if(this.WattsPerArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WattsPerArea, must be a value greater than or equal to 0.", new [] { "WattsPerArea" });
            }

            // Schedule (string) maxLength
            if(this.Schedule != null && this.Schedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be less than 100.", new [] { "Schedule" });
            }

            // Schedule (string) minLength
            if(this.Schedule != null && this.Schedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be greater than 1.", new [] { "Schedule" });
            }

            // RadiantFraction (double) maximum
            if(this.RadiantFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value less than or equal to 1.", new [] { "RadiantFraction" });
            }

            // RadiantFraction (double) minimum
            if(this.RadiantFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value greater than or equal to 0.", new [] { "RadiantFraction" });
            }

            // LatentFraction (double) maximum
            if(this.LatentFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentFraction, must be a value less than or equal to 1.", new [] { "LatentFraction" });
            }

            // LatentFraction (double) minimum
            if(this.LatentFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentFraction, must be a value greater than or equal to 0.", new [] { "LatentFraction" });
            }

            // LostFraction (double) maximum
            if(this.LostFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LostFraction, must be a value less than or equal to 1.", new [] { "LostFraction" });
            }

            // LostFraction (double) minimum
            if(this.LostFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LostFraction, must be a value greater than or equal to 0.", new [] { "LostFraction" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^ElectricEquipmentAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
