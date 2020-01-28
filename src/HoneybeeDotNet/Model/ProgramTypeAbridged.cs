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
    /// Base class for all objects requiring a valid EnergyPlus name.
    /// </summary>
    [DataContract]
    public partial class ProgramTypeAbridged :  IEquatable<ProgramTypeAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramTypeAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgramTypeAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramTypeAbridged" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="type">type (default to &quot;ProgramTypeAbridged&quot;).</param>
        /// <param name="people">People to describe the occupancy of the program. If None, no occupancy will be assumed for the program..</param>
        /// <param name="lighting">Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program..</param>
        /// <param name="electricalEquipment">ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed..</param>
        /// <param name="gasEquipment">GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed..</param>
        /// <param name="infiltration">Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program..</param>
        /// <param name="ventilation">Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed..</param>
        /// <param name="setpoint">Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned..</param>
        public ProgramTypeAbridged(string name, string type = "ProgramTypeAbridged", PeopleAbridged people = default(PeopleAbridged), LightingAbridged lighting = default(LightingAbridged), ElectricEquipmentAbridged electricalEquipment = default(ElectricEquipmentAbridged), GasEquipmentAbridged gasEquipment = default(GasEquipmentAbridged), InfiltrationAbridged infiltration = default(InfiltrationAbridged), VentilationAbridged ventilation = default(VentilationAbridged), SetpointAbridged setpoint = default(SetpointAbridged))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProgramTypeAbridged and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ProgramTypeAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.People = people;
            this.Lighting = lighting;
            this.ElectricalEquipment = electricalEquipment;
            this.GasEquipment = gasEquipment;
            this.Infiltration = infiltration;
            this.Ventilation = ventilation;
            this.Setpoint = setpoint;
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.
        /// </summary>
        /// <value>People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.</value>
        [DataMember(Name="people", EmitDefaultValue=false)]
        [JsonProperty("people")]
        public PeopleAbridged People { get; set; }

        /// <summary>
        /// Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.
        /// </summary>
        /// <value>Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.</value>
        [DataMember(Name="lighting", EmitDefaultValue=false)]
        [JsonProperty("lighting")]
        public LightingAbridged Lighting { get; set; }

        /// <summary>
        /// ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.
        /// </summary>
        /// <value>ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.</value>
        [DataMember(Name="electrical_equipment", EmitDefaultValue=false)]
        [JsonProperty("electrical_equipment")]
        public ElectricEquipmentAbridged ElectricalEquipment { get; set; }

        /// <summary>
        /// GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.
        /// </summary>
        /// <value>GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.</value>
        [DataMember(Name="gas_equipment", EmitDefaultValue=false)]
        [JsonProperty("gas_equipment")]
        public GasEquipmentAbridged GasEquipment { get; set; }

        /// <summary>
        /// Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.
        /// </summary>
        /// <value>Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.</value>
        [DataMember(Name="infiltration", EmitDefaultValue=false)]
        [JsonProperty("infiltration")]
        public InfiltrationAbridged Infiltration { get; set; }

        /// <summary>
        /// Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.
        /// </summary>
        /// <value>Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.</value>
        [DataMember(Name="ventilation", EmitDefaultValue=false)]
        [JsonProperty("ventilation")]
        public VentilationAbridged Ventilation { get; set; }

        /// <summary>
        /// Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.
        /// </summary>
        /// <value>Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.</value>
        [DataMember(Name="setpoint", EmitDefaultValue=false)]
        [JsonProperty("setpoint")]
        public SetpointAbridged Setpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramTypeAbridged {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Lighting: ").Append(Lighting).Append("\n");
            sb.Append("  ElectricalEquipment: ").Append(ElectricalEquipment).Append("\n");
            sb.Append("  GasEquipment: ").Append(GasEquipment).Append("\n");
            sb.Append("  Infiltration: ").Append(Infiltration).Append("\n");
            sb.Append("  Ventilation: ").Append(Ventilation).Append("\n");
            sb.Append("  Setpoint: ").Append(Setpoint).Append("\n");
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
            return this.Equals(input as ProgramTypeAbridged);
        }

        /// <summary>
        /// Returns true if ProgramTypeAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ProgramTypeAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramTypeAbridged input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.People == input.People ||
                    (this.People != null &&
                    this.People.Equals(input.People))
                ) && 
                (
                    this.Lighting == input.Lighting ||
                    (this.Lighting != null &&
                    this.Lighting.Equals(input.Lighting))
                ) && 
                (
                    this.ElectricalEquipment == input.ElectricalEquipment ||
                    (this.ElectricalEquipment != null &&
                    this.ElectricalEquipment.Equals(input.ElectricalEquipment))
                ) && 
                (
                    this.GasEquipment == input.GasEquipment ||
                    (this.GasEquipment != null &&
                    this.GasEquipment.Equals(input.GasEquipment))
                ) && 
                (
                    this.Infiltration == input.Infiltration ||
                    (this.Infiltration != null &&
                    this.Infiltration.Equals(input.Infiltration))
                ) && 
                (
                    this.Ventilation == input.Ventilation ||
                    (this.Ventilation != null &&
                    this.Ventilation.Equals(input.Ventilation))
                ) && 
                (
                    this.Setpoint == input.Setpoint ||
                    (this.Setpoint != null &&
                    this.Setpoint.Equals(input.Setpoint))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.People != null)
                    hashCode = hashCode * 59 + this.People.GetHashCode();
                if (this.Lighting != null)
                    hashCode = hashCode * 59 + this.Lighting.GetHashCode();
                if (this.ElectricalEquipment != null)
                    hashCode = hashCode * 59 + this.ElectricalEquipment.GetHashCode();
                if (this.GasEquipment != null)
                    hashCode = hashCode * 59 + this.GasEquipment.GetHashCode();
                if (this.Infiltration != null)
                    hashCode = hashCode * 59 + this.Infiltration.GetHashCode();
                if (this.Ventilation != null)
                    hashCode = hashCode * 59 + this.Ventilation.GetHashCode();
                if (this.Setpoint != null)
                    hashCode = hashCode * 59 + this.Setpoint.GetHashCode();
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

            // Type (string) pattern
            Regex regexType = new Regex(@"^ProgramTypeAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
