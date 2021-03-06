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
    public partial class LightingAbridged :  IEquatable<LightingAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightingAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LightingAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LightingAbridged" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="wattsPerArea">Lighting per floor area as [W/m2]. (required).</param>
        /// <param name="schedule">Name of the schedule for the use of lights over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete lighting profile. (required).</param>
        /// <param name="type">type (default to &quot;LightingAbridged&quot;).</param>
        /// <param name="visibleFraction">The fraction of heat from lights that goes into the zone as visible (short-wave) radiation. The default value is &#x60;0.25&#x60;. (default to 0.25).</param>
        /// <param name="radiantFraction">The fraction of heat from lights that is long-wave radiation. Default value is &#x60;0.32&#x60;. (default to 0.32).</param>
        /// <param name="returnAirFraction">The fraction of the heat from lights that goes into the zone return air. Default value is &#x60;0&#x60;. (default to 0.0).</param>
        public LightingAbridged(string name, double wattsPerArea, string schedule, string type = "LightingAbridged", double visibleFraction = 0.25, double radiantFraction = 0.32, double returnAirFraction = 0.0)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LightingAbridged and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "wattsPerArea" is required (not null)
            if (wattsPerArea == null)
            {
                throw new InvalidDataException("wattsPerArea is a required property for LightingAbridged and cannot be null");
            }
            else
            {
                this.WattsPerArea = wattsPerArea;
            }
            
            // to ensure "schedule" is required (not null)
            if (schedule == null)
            {
                throw new InvalidDataException("schedule is a required property for LightingAbridged and cannot be null");
            }
            else
            {
                this.Schedule = schedule;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "LightingAbridged";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "visibleFraction" provided
            if (visibleFraction == null)
            {
                this.VisibleFraction = 0.25;
            }
            else
            {
                this.VisibleFraction = visibleFraction;
            }
            // use default value if no "radiantFraction" provided
            if (radiantFraction == null)
            {
                this.RadiantFraction = 0.32;
            }
            else
            {
                this.RadiantFraction = radiantFraction;
            }
            // use default value if no "returnAirFraction" provided
            if (returnAirFraction == null)
            {
                this.ReturnAirFraction = 0.0;
            }
            else
            {
                this.ReturnAirFraction = returnAirFraction;
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
        /// Lighting per floor area as [W/m2].
        /// </summary>
        /// <value>Lighting per floor area as [W/m2].</value>
        [DataMember(Name="watts_per_area", EmitDefaultValue=false)]
        [JsonProperty("watts_per_area")]
        public double WattsPerArea { get; set; }

        /// <summary>
        /// Name of the schedule for the use of lights over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete lighting profile.
        /// </summary>
        /// <value>Name of the schedule for the use of lights over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete lighting profile.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The fraction of heat from lights that goes into the zone as visible (short-wave) radiation. The default value is &#x60;0.25&#x60;.
        /// </summary>
        /// <value>The fraction of heat from lights that goes into the zone as visible (short-wave) radiation. The default value is &#x60;0.25&#x60;.</value>
        [DataMember(Name="visible_fraction", EmitDefaultValue=false)]
        [JsonProperty("visible_fraction")]
        public double VisibleFraction { get; set; }

        /// <summary>
        /// The fraction of heat from lights that is long-wave radiation. Default value is &#x60;0.32&#x60;.
        /// </summary>
        /// <value>The fraction of heat from lights that is long-wave radiation. Default value is &#x60;0.32&#x60;.</value>
        [DataMember(Name="radiant_fraction", EmitDefaultValue=false)]
        [JsonProperty("radiant_fraction")]
        public double RadiantFraction { get; set; }

        /// <summary>
        /// The fraction of the heat from lights that goes into the zone return air. Default value is &#x60;0&#x60;.
        /// </summary>
        /// <value>The fraction of the heat from lights that goes into the zone return air. Default value is &#x60;0&#x60;.</value>
        [DataMember(Name="return_air_fraction", EmitDefaultValue=false)]
        [JsonProperty("return_air_fraction")]
        public double ReturnAirFraction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LightingAbridged {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WattsPerArea: ").Append(WattsPerArea).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VisibleFraction: ").Append(VisibleFraction).Append("\n");
            sb.Append("  RadiantFraction: ").Append(RadiantFraction).Append("\n");
            sb.Append("  ReturnAirFraction: ").Append(ReturnAirFraction).Append("\n");
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
        /// <returns>LightingAbridged object</returns>
        public static LightingAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<LightingAbridged>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LightingAbridged);
        }

        /// <summary>
        /// Returns true if LightingAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of LightingAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LightingAbridged input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VisibleFraction == input.VisibleFraction ||
                    (this.VisibleFraction != null &&
                    this.VisibleFraction.Equals(input.VisibleFraction))
                ) && 
                (
                    this.RadiantFraction == input.RadiantFraction ||
                    (this.RadiantFraction != null &&
                    this.RadiantFraction.Equals(input.RadiantFraction))
                ) && 
                (
                    this.ReturnAirFraction == input.ReturnAirFraction ||
                    (this.ReturnAirFraction != null &&
                    this.ReturnAirFraction.Equals(input.ReturnAirFraction))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VisibleFraction != null)
                    hashCode = hashCode * 59 + this.VisibleFraction.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.ReturnAirFraction != null)
                    hashCode = hashCode * 59 + this.ReturnAirFraction.GetHashCode();
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

            // Type (string) pattern
            Regex regexType = new Regex(@"^LightingAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // VisibleFraction (double) maximum
            if(this.VisibleFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleFraction, must be a value less than or equal to 1.", new [] { "VisibleFraction" });
            }

            // VisibleFraction (double) minimum
            if(this.VisibleFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleFraction, must be a value greater than or equal to 0.", new [] { "VisibleFraction" });
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

            // ReturnAirFraction (double) maximum
            if(this.ReturnAirFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReturnAirFraction, must be a value less than or equal to 1.", new [] { "ReturnAirFraction" });
            }

            // ReturnAirFraction (double) minimum
            if(this.ReturnAirFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReturnAirFraction, must be a value greater than or equal to 0.", new [] { "ReturnAirFraction" });
            }

            yield break;
        }
    }

}
