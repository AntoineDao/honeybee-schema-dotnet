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
    /// A set of constructions for different surface types and boundary conditions.
    /// </summary>
    [DataContract]
    public partial class ConstructionSetAbridged :  IEquatable<ConstructionSetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionSetAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConstructionSetAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionSetAbridged" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="type">type (default to &quot;ConstructionSetAbridged&quot;).</param>
        /// <param name="wallSet">A WallSet object for this ConstructionSet..</param>
        /// <param name="floorSet">A FloorSet object for this ConstructionSet..</param>
        /// <param name="roofCeilingSet">A RoofCeilingSet object for this ConstructionSet..</param>
        /// <param name="apertureSet">A ApertureSet object for this ConstructionSet..</param>
        /// <param name="doorSet">A DoorSet object for this ConstructionSet..</param>
        /// <param name="shadeConstruction">The name of a ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned..</param>
        /// <param name="airBoundaryConstruction">The name of an AirBoundaryConstruction to set the properties of Faces with an AirBoundary type..</param>
        public ConstructionSetAbridged(string name, string type = "ConstructionSetAbridged", WallSetAbridged wallSet = default, FloorSetAbridged floorSet = default, RoofCeilingSetAbridged roofCeilingSet = default, ApertureSetAbridged apertureSet = default, DoorSetAbridged doorSet = default, string shadeConstruction = default, string airBoundaryConstruction = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ConstructionSetAbridged and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ConstructionSetAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.WallSet = wallSet;
            this.FloorSet = floorSet;
            this.RoofCeilingSet = roofCeilingSet;
            this.ApertureSet = apertureSet;
            this.DoorSet = doorSet;
            this.ShadeConstruction = shadeConstruction;
            this.AirBoundaryConstruction = airBoundaryConstruction;
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
        /// A WallSet object for this ConstructionSet.
        /// </summary>
        /// <value>A WallSet object for this ConstructionSet.</value>
        [DataMember(Name="wall_set", EmitDefaultValue=false)]
        [JsonProperty("wall_set")]
        public WallSetAbridged WallSet { get; set; }

        /// <summary>
        /// A FloorSet object for this ConstructionSet.
        /// </summary>
        /// <value>A FloorSet object for this ConstructionSet.</value>
        [DataMember(Name="floor_set", EmitDefaultValue=false)]
        [JsonProperty("floor_set")]
        public FloorSetAbridged FloorSet { get; set; }

        /// <summary>
        /// A RoofCeilingSet object for this ConstructionSet.
        /// </summary>
        /// <value>A RoofCeilingSet object for this ConstructionSet.</value>
        [DataMember(Name="roof_ceiling_set", EmitDefaultValue=false)]
        [JsonProperty("roof_ceiling_set")]
        public RoofCeilingSetAbridged RoofCeilingSet { get; set; }

        /// <summary>
        /// A ApertureSet object for this ConstructionSet.
        /// </summary>
        /// <value>A ApertureSet object for this ConstructionSet.</value>
        [DataMember(Name="aperture_set", EmitDefaultValue=false)]
        [JsonProperty("aperture_set")]
        public ApertureSetAbridged ApertureSet { get; set; }

        /// <summary>
        /// A DoorSet object for this ConstructionSet.
        /// </summary>
        /// <value>A DoorSet object for this ConstructionSet.</value>
        [DataMember(Name="door_set", EmitDefaultValue=false)]
        [JsonProperty("door_set")]
        public DoorSetAbridged DoorSet { get; set; }

        /// <summary>
        /// The name of a ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned.
        /// </summary>
        /// <value>The name of a ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned.</value>
        [DataMember(Name="shade_construction", EmitDefaultValue=false)]
        [JsonProperty("shade_construction")]
        public string ShadeConstruction { get; set; }

        /// <summary>
        /// The name of an AirBoundaryConstruction to set the properties of Faces with an AirBoundary type.
        /// </summary>
        /// <value>The name of an AirBoundaryConstruction to set the properties of Faces with an AirBoundary type.</value>
        [DataMember(Name="air_boundary_construction", EmitDefaultValue=false)]
        [JsonProperty("air_boundary_construction")]
        public string AirBoundaryConstruction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstructionSetAbridged {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WallSet: ").Append(WallSet).Append("\n");
            sb.Append("  FloorSet: ").Append(FloorSet).Append("\n");
            sb.Append("  RoofCeilingSet: ").Append(RoofCeilingSet).Append("\n");
            sb.Append("  ApertureSet: ").Append(ApertureSet).Append("\n");
            sb.Append("  DoorSet: ").Append(DoorSet).Append("\n");
            sb.Append("  ShadeConstruction: ").Append(ShadeConstruction).Append("\n");
            sb.Append("  AirBoundaryConstruction: ").Append(AirBoundaryConstruction).Append("\n");
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
        /// <returns>ConstructionSetAbridged object</returns>
        public static ConstructionSetAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ConstructionSetAbridged>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConstructionSetAbridged);
        }

        /// <summary>
        /// Returns true if ConstructionSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstructionSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionSetAbridged input)
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
                    this.WallSet == input.WallSet ||
                    (this.WallSet != null &&
                    this.WallSet.Equals(input.WallSet))
                ) && 
                (
                    this.FloorSet == input.FloorSet ||
                    (this.FloorSet != null &&
                    this.FloorSet.Equals(input.FloorSet))
                ) && 
                (
                    this.RoofCeilingSet == input.RoofCeilingSet ||
                    (this.RoofCeilingSet != null &&
                    this.RoofCeilingSet.Equals(input.RoofCeilingSet))
                ) && 
                (
                    this.ApertureSet == input.ApertureSet ||
                    (this.ApertureSet != null &&
                    this.ApertureSet.Equals(input.ApertureSet))
                ) && 
                (
                    this.DoorSet == input.DoorSet ||
                    (this.DoorSet != null &&
                    this.DoorSet.Equals(input.DoorSet))
                ) && 
                (
                    this.ShadeConstruction == input.ShadeConstruction ||
                    (this.ShadeConstruction != null &&
                    this.ShadeConstruction.Equals(input.ShadeConstruction))
                ) && 
                (
                    this.AirBoundaryConstruction == input.AirBoundaryConstruction ||
                    (this.AirBoundaryConstruction != null &&
                    this.AirBoundaryConstruction.Equals(input.AirBoundaryConstruction))
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
                if (this.WallSet != null)
                    hashCode = hashCode * 59 + this.WallSet.GetHashCode();
                if (this.FloorSet != null)
                    hashCode = hashCode * 59 + this.FloorSet.GetHashCode();
                if (this.RoofCeilingSet != null)
                    hashCode = hashCode * 59 + this.RoofCeilingSet.GetHashCode();
                if (this.ApertureSet != null)
                    hashCode = hashCode * 59 + this.ApertureSet.GetHashCode();
                if (this.DoorSet != null)
                    hashCode = hashCode * 59 + this.DoorSet.GetHashCode();
                if (this.ShadeConstruction != null)
                    hashCode = hashCode * 59 + this.ShadeConstruction.GetHashCode();
                if (this.AirBoundaryConstruction != null)
                    hashCode = hashCode * 59 + this.AirBoundaryConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^ConstructionSetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ShadeConstruction (string) maxLength
            if(this.ShadeConstruction != null && this.ShadeConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShadeConstruction, length must be less than 100.", new [] { "ShadeConstruction" });
            }

            // ShadeConstruction (string) minLength
            if(this.ShadeConstruction != null && this.ShadeConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShadeConstruction, length must be greater than 1.", new [] { "ShadeConstruction" });
            }

            // AirBoundaryConstruction (string) maxLength
            if(this.AirBoundaryConstruction != null && this.AirBoundaryConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirBoundaryConstruction, length must be less than 100.", new [] { "AirBoundaryConstruction" });
            }

            // AirBoundaryConstruction (string) minLength
            if(this.AirBoundaryConstruction != null && this.AirBoundaryConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirBoundaryConstruction, length must be greater than 1.", new [] { "AirBoundaryConstruction" });
            }

            yield break;
        }
    }

}
