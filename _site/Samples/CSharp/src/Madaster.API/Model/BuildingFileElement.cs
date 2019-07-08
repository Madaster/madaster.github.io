/* 
 * Madaster Private API
 *
 * The Madaster Private API endpoint.
 *
 * OpenAPI spec version: 1.1
 * Contact: service@madaster.com
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
using SwaggerDateConverter = Madaster.API.Client.SwaggerDateConverter;

namespace Madaster.API.Model
{
    /// <summary>
    /// A building file element
    /// </summary>
    [DataContract]
    public partial class BuildingFileElement :  IEquatable<BuildingFileElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingFileElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildingFileElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingFileElement" /> class.
        /// </summary>
        /// <param name="id">The identifier of the element (required).</param>
        /// <param name="buildingFileId">The identifier of the building file that this building file element belongs to..</param>
        /// <param name="materialName">The name of the element.</param>
        /// <param name="typeName">The type name of the element.</param>
        /// <param name="elementClass">The element class of the element.</param>
        /// <param name="volume">The volume of the element.</param>
        /// <param name="area">The area of the element.</param>
        /// <param name="height">The height of the element.</param>
        /// <param name="width">The width of the element.</param>
        /// <param name="length">The length of the element.</param>
        /// <param name="weight">The weight of the element.</param>
        /// <param name="mapping">The mapping of the element.</param>
        /// <param name="phase">The building process phase of the element.</param>
        /// <param name="brandLayer">The brandlayer of the element.</param>
        /// <param name="classification">The classification of the element.</param>
        /// <param name="floor">The floor of the element.</param>
        public BuildingFileElement(string id = default(string), Guid? buildingFileId = default(Guid?), string materialName = default(string), string typeName = default(string), string elementClass = default(string), double? volume = default(double?), double? area = default(double?), double? height = default(double?), double? width = default(double?), double? length = default(double?), double? weight = default(double?), Mapping mapping = default(Mapping), Phase phase = default(Phase), BrandLayer brandLayer = default(BrandLayer), Classification classification = default(Classification), string floor = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BuildingFileElement and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            this.BuildingFileId = buildingFileId;
            this.MaterialName = materialName;
            this.TypeName = typeName;
            this.ElementClass = elementClass;
            this.Volume = volume;
            this.Area = area;
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Weight = weight;
            this.Mapping = mapping;
            this.Phase = phase;
            this.BrandLayer = brandLayer;
            this.Classification = classification;
            this.Floor = floor;
        }
        
        /// <summary>
        /// The identifier of the element
        /// </summary>
        /// <value>The identifier of the element</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the building file that this building file element belongs to.
        /// </summary>
        /// <value>The identifier of the building file that this building file element belongs to.</value>
        [DataMember(Name="buildingFileId", EmitDefaultValue=false)]
        public Guid? BuildingFileId { get; set; }

        /// <summary>
        /// The name of the element
        /// </summary>
        /// <value>The name of the element</value>
        [DataMember(Name="materialName", EmitDefaultValue=false)]
        public string MaterialName { get; set; }

        /// <summary>
        /// The type name of the element
        /// </summary>
        /// <value>The type name of the element</value>
        [DataMember(Name="typeName", EmitDefaultValue=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// The element class of the element
        /// </summary>
        /// <value>The element class of the element</value>
        [DataMember(Name="elementClass", EmitDefaultValue=false)]
        public string ElementClass { get; set; }

        /// <summary>
        /// The volume of the element
        /// </summary>
        /// <value>The volume of the element</value>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public double? Volume { get; set; }

        /// <summary>
        /// The area of the element
        /// </summary>
        /// <value>The area of the element</value>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public double? Area { get; set; }

        /// <summary>
        /// The height of the element
        /// </summary>
        /// <value>The height of the element</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// The width of the element
        /// </summary>
        /// <value>The width of the element</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// The length of the element
        /// </summary>
        /// <value>The length of the element</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public double? Length { get; set; }

        /// <summary>
        /// The weight of the element
        /// </summary>
        /// <value>The weight of the element</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public double? Weight { get; set; }

        /// <summary>
        /// The mapping of the element
        /// </summary>
        /// <value>The mapping of the element</value>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public Mapping Mapping { get; set; }

        /// <summary>
        /// The building process phase of the element
        /// </summary>
        /// <value>The building process phase of the element</value>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public Phase Phase { get; set; }

        /// <summary>
        /// The brandlayer of the element
        /// </summary>
        /// <value>The brandlayer of the element</value>
        [DataMember(Name="brandLayer", EmitDefaultValue=false)]
        public BrandLayer BrandLayer { get; set; }

        /// <summary>
        /// The classification of the element
        /// </summary>
        /// <value>The classification of the element</value>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public Classification Classification { get; set; }

        /// <summary>
        /// The floor of the element
        /// </summary>
        /// <value>The floor of the element</value>
        [DataMember(Name="floor", EmitDefaultValue=false)]
        public string Floor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildingFileElement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BuildingFileId: ").Append(BuildingFileId).Append("\n");
            sb.Append("  MaterialName: ").Append(MaterialName).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  ElementClass: ").Append(ElementClass).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
            sb.Append("  BrandLayer: ").Append(BrandLayer).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Floor: ").Append(Floor).Append("\n");
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
            return this.Equals(input as BuildingFileElement);
        }

        /// <summary>
        /// Returns true if BuildingFileElement instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingFileElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingFileElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.BuildingFileId == input.BuildingFileId ||
                    (this.BuildingFileId != null &&
                    this.BuildingFileId.Equals(input.BuildingFileId))
                ) && 
                (
                    this.MaterialName == input.MaterialName ||
                    (this.MaterialName != null &&
                    this.MaterialName.Equals(input.MaterialName))
                ) && 
                (
                    this.TypeName == input.TypeName ||
                    (this.TypeName != null &&
                    this.TypeName.Equals(input.TypeName))
                ) && 
                (
                    this.ElementClass == input.ElementClass ||
                    (this.ElementClass != null &&
                    this.ElementClass.Equals(input.ElementClass))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.BrandLayer == input.BrandLayer ||
                    (this.BrandLayer != null &&
                    this.BrandLayer.Equals(input.BrandLayer))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Floor == input.Floor ||
                    (this.Floor != null &&
                    this.Floor.Equals(input.Floor))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BuildingFileId != null)
                    hashCode = hashCode * 59 + this.BuildingFileId.GetHashCode();
                if (this.MaterialName != null)
                    hashCode = hashCode * 59 + this.MaterialName.GetHashCode();
                if (this.TypeName != null)
                    hashCode = hashCode * 59 + this.TypeName.GetHashCode();
                if (this.ElementClass != null)
                    hashCode = hashCode * 59 + this.ElementClass.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Mapping != null)
                    hashCode = hashCode * 59 + this.Mapping.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.BrandLayer != null)
                    hashCode = hashCode * 59 + this.BrandLayer.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Floor != null)
                    hashCode = hashCode * 59 + this.Floor.GetHashCode();
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
            yield break;
        }
    }

}
