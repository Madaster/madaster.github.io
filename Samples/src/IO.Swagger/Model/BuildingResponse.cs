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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// BuildingResponse
    /// </summary>
    [DataContract]
    public partial class BuildingResponse :  IEquatable<BuildingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingResponse" /> class.
        /// </summary>
        /// <param name="portfolioId">portfolioId.</param>
        /// <param name="name">name.</param>
        /// <param name="images">images.</param>
        /// <param name="cadastralDesignation">cadastralDesignation.</param>
        /// <param name="cadastralArea">cadastralArea.</param>
        /// <param name="parcelnumber">parcelnumber.</param>
        /// <param name="publicLawRestriction">publicLawRestriction.</param>
        /// <param name="completionDate">completionDate.</param>
        /// <param name="lastRenovationDate">lastRenovationDate.</param>
        /// <param name="addressStreet">addressStreet.</param>
        /// <param name="addressHousenumber">addressHousenumber.</param>
        /// <param name="addressHousenumberAddition">addressHousenumberAddition.</param>
        /// <param name="addressZipcode">addressZipcode.</param>
        /// <param name="addressCity">addressCity.</param>
        /// <param name="addressCountry">addressCountry.</param>
        /// <param name="buildingUsage">buildingUsage.</param>
        /// <param name="grossSurfaceArea">grossSurfaceArea.</param>
        /// <param name="energyLabel">energyLabel.</param>
        /// <param name="energyPerformanceCoefficient">energyPerformanceCoefficient.</param>
        /// <param name="energyIndex">energyIndex.</param>
        /// <param name="expectedLifespan">expectedLifespan.</param>
        /// <param name="expectedLifespanStructure">expectedLifespanStructure.</param>
        /// <param name="expectedLifespanSkin">expectedLifespanSkin.</param>
        /// <param name="expectedLifespanServices">expectedLifespanServices.</param>
        /// <param name="expectedLifespanSpacePlan">expectedLifespanSpacePlan.</param>
        /// <param name="expectedLifespanStuff">expectedLifespanStuff.</param>
        /// <param name="breeamLabel">breeamLabel.</param>
        /// <param name="gprLabel">gprLabel.</param>
        /// <param name="mpgLabel">mpgLabel.</param>
        /// <param name="mpgLabelManual">mpgLabelManual.</param>
        /// <param name="mpgLabelIndicative">mpgLabelIndicative.</param>
        /// <param name="leedLabel">leedLabel.</param>
        /// <param name="isDirty">isDirty.</param>
        /// <param name="hasDirtyElements">hasDirtyElements.</param>
        /// <param name="mostRecentBimInfo">mostRecentBimInfo.</param>
        /// <param name="geoLatitude">geoLatitude.</param>
        /// <param name="geoLongtitude">geoLongtitude.</param>
        /// <param name="phaseType">phaseType.</param>
        /// <param name="classificationType">classificationType.</param>
        /// <param name="id">id.</param>
        public BuildingResponse(Guid? portfolioId = default(Guid?), string name = default(string), List<string> images = default(List<string>), string cadastralDesignation = default(string), int? cadastralArea = default(int?), string parcelnumber = default(string), string publicLawRestriction = default(string), DateTime? completionDate = default(DateTime?), DateTime? lastRenovationDate = default(DateTime?), string addressStreet = default(string), string addressHousenumber = default(string), string addressHousenumberAddition = default(string), string addressZipcode = default(string), string addressCity = default(string), string addressCountry = default(string), string buildingUsage = default(string), double? grossSurfaceArea = default(double?), string energyLabel = default(string), double? energyPerformanceCoefficient = default(double?), double? energyIndex = default(double?), int? expectedLifespan = default(int?), int? expectedLifespanStructure = default(int?), int? expectedLifespanSkin = default(int?), int? expectedLifespanServices = default(int?), int? expectedLifespanSpacePlan = default(int?), int? expectedLifespanStuff = default(int?), int? breeamLabel = default(int?), double? gprLabel = default(double?), double? mpgLabel = default(double?), double? mpgLabelManual = default(double?), double? mpgLabelIndicative = default(double?), string leedLabel = default(string), bool? isDirty = default(bool?), bool? hasDirtyElements = default(bool?), DateTime? mostRecentBimInfo = default(DateTime?), double? geoLatitude = default(double?), double? geoLongtitude = default(double?), Guid? phaseType = default(Guid?), Guid? classificationType = default(Guid?), Guid? id = default(Guid?))
        {
            this.PortfolioId = portfolioId;
            this.Name = name;
            this.Images = images;
            this.CadastralDesignation = cadastralDesignation;
            this.CadastralArea = cadastralArea;
            this.Parcelnumber = parcelnumber;
            this.PublicLawRestriction = publicLawRestriction;
            this.CompletionDate = completionDate;
            this.LastRenovationDate = lastRenovationDate;
            this.AddressStreet = addressStreet;
            this.AddressHousenumber = addressHousenumber;
            this.AddressHousenumberAddition = addressHousenumberAddition;
            this.AddressZipcode = addressZipcode;
            this.AddressCity = addressCity;
            this.AddressCountry = addressCountry;
            this.BuildingUsage = buildingUsage;
            this.GrossSurfaceArea = grossSurfaceArea;
            this.EnergyLabel = energyLabel;
            this.EnergyPerformanceCoefficient = energyPerformanceCoefficient;
            this.EnergyIndex = energyIndex;
            this.ExpectedLifespan = expectedLifespan;
            this.ExpectedLifespanStructure = expectedLifespanStructure;
            this.ExpectedLifespanSkin = expectedLifespanSkin;
            this.ExpectedLifespanServices = expectedLifespanServices;
            this.ExpectedLifespanSpacePlan = expectedLifespanSpacePlan;
            this.ExpectedLifespanStuff = expectedLifespanStuff;
            this.BreeamLabel = breeamLabel;
            this.GprLabel = gprLabel;
            this.MpgLabel = mpgLabel;
            this.MpgLabelManual = mpgLabelManual;
            this.MpgLabelIndicative = mpgLabelIndicative;
            this.LeedLabel = leedLabel;
            this.IsDirty = isDirty;
            this.HasDirtyElements = hasDirtyElements;
            this.MostRecentBimInfo = mostRecentBimInfo;
            this.GeoLatitude = geoLatitude;
            this.GeoLongtitude = geoLongtitude;
            this.PhaseType = phaseType;
            this.ClassificationType = classificationType;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name="portfolioId", EmitDefaultValue=false)]
        public Guid? PortfolioId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// Gets or Sets CadastralDesignation
        /// </summary>
        [DataMember(Name="cadastralDesignation", EmitDefaultValue=false)]
        public string CadastralDesignation { get; set; }

        /// <summary>
        /// Gets or Sets CadastralArea
        /// </summary>
        [DataMember(Name="cadastralArea", EmitDefaultValue=false)]
        public int? CadastralArea { get; set; }

        /// <summary>
        /// Gets or Sets Parcelnumber
        /// </summary>
        [DataMember(Name="parcelnumber", EmitDefaultValue=false)]
        public string Parcelnumber { get; set; }

        /// <summary>
        /// Gets or Sets PublicLawRestriction
        /// </summary>
        [DataMember(Name="publicLawRestriction", EmitDefaultValue=false)]
        public string PublicLawRestriction { get; set; }

        /// <summary>
        /// Gets or Sets CompletionDate
        /// </summary>
        [DataMember(Name="completionDate", EmitDefaultValue=false)]
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Gets or Sets LastRenovationDate
        /// </summary>
        [DataMember(Name="lastRenovationDate", EmitDefaultValue=false)]
        public DateTime? LastRenovationDate { get; set; }

        /// <summary>
        /// Gets or Sets AddressStreet
        /// </summary>
        [DataMember(Name="addressStreet", EmitDefaultValue=false)]
        public string AddressStreet { get; set; }

        /// <summary>
        /// Gets or Sets AddressHousenumber
        /// </summary>
        [DataMember(Name="addressHousenumber", EmitDefaultValue=false)]
        public string AddressHousenumber { get; set; }

        /// <summary>
        /// Gets or Sets AddressHousenumberAddition
        /// </summary>
        [DataMember(Name="addressHousenumberAddition", EmitDefaultValue=false)]
        public string AddressHousenumberAddition { get; set; }

        /// <summary>
        /// Gets or Sets AddressZipcode
        /// </summary>
        [DataMember(Name="addressZipcode", EmitDefaultValue=false)]
        public string AddressZipcode { get; set; }

        /// <summary>
        /// Gets or Sets AddressCity
        /// </summary>
        [DataMember(Name="addressCity", EmitDefaultValue=false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Gets or Sets AddressCountry
        /// </summary>
        [DataMember(Name="addressCountry", EmitDefaultValue=false)]
        public string AddressCountry { get; set; }

        /// <summary>
        /// Gets or Sets BuildingUsage
        /// </summary>
        [DataMember(Name="buildingUsage", EmitDefaultValue=false)]
        public string BuildingUsage { get; set; }

        /// <summary>
        /// Gets or Sets GrossSurfaceArea
        /// </summary>
        [DataMember(Name="grossSurfaceArea", EmitDefaultValue=false)]
        public double? GrossSurfaceArea { get; set; }

        /// <summary>
        /// Gets or Sets EnergyLabel
        /// </summary>
        [DataMember(Name="energyLabel", EmitDefaultValue=false)]
        public string EnergyLabel { get; set; }

        /// <summary>
        /// Gets or Sets EnergyPerformanceCoefficient
        /// </summary>
        [DataMember(Name="energyPerformanceCoefficient", EmitDefaultValue=false)]
        public double? EnergyPerformanceCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets EnergyIndex
        /// </summary>
        [DataMember(Name="energyIndex", EmitDefaultValue=false)]
        public double? EnergyIndex { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedLifespan
        /// </summary>
        [DataMember(Name="expectedLifespan", EmitDefaultValue=false)]
        public int? ExpectedLifespan { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedLifespanStructure
        /// </summary>
        [DataMember(Name="expectedLifespanStructure", EmitDefaultValue=false)]
        public int? ExpectedLifespanStructure { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedLifespanSkin
        /// </summary>
        [DataMember(Name="expectedLifespanSkin", EmitDefaultValue=false)]
        public int? ExpectedLifespanSkin { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedLifespanServices
        /// </summary>
        [DataMember(Name="expectedLifespanServices", EmitDefaultValue=false)]
        public int? ExpectedLifespanServices { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedLifespanSpacePlan
        /// </summary>
        [DataMember(Name="expectedLifespanSpacePlan", EmitDefaultValue=false)]
        public int? ExpectedLifespanSpacePlan { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedLifespanStuff
        /// </summary>
        [DataMember(Name="expectedLifespanStuff", EmitDefaultValue=false)]
        public int? ExpectedLifespanStuff { get; set; }

        /// <summary>
        /// Gets or Sets BreeamLabel
        /// </summary>
        [DataMember(Name="breeamLabel", EmitDefaultValue=false)]
        public int? BreeamLabel { get; set; }

        /// <summary>
        /// Gets or Sets GprLabel
        /// </summary>
        [DataMember(Name="gprLabel", EmitDefaultValue=false)]
        public double? GprLabel { get; set; }

        /// <summary>
        /// Gets or Sets MpgLabel
        /// </summary>
        [DataMember(Name="mpgLabel", EmitDefaultValue=false)]
        public double? MpgLabel { get; set; }

        /// <summary>
        /// Gets or Sets MpgLabelManual
        /// </summary>
        [DataMember(Name="mpgLabelManual", EmitDefaultValue=false)]
        public double? MpgLabelManual { get; set; }

        /// <summary>
        /// Gets or Sets MpgLabelIndicative
        /// </summary>
        [DataMember(Name="mpgLabelIndicative", EmitDefaultValue=false)]
        public double? MpgLabelIndicative { get; set; }

        /// <summary>
        /// Gets or Sets LeedLabel
        /// </summary>
        [DataMember(Name="leedLabel", EmitDefaultValue=false)]
        public string LeedLabel { get; set; }

        /// <summary>
        /// Gets or Sets IsDirty
        /// </summary>
        [DataMember(Name="isDirty", EmitDefaultValue=false)]
        public bool? IsDirty { get; set; }

        /// <summary>
        /// Gets or Sets HasDirtyElements
        /// </summary>
        [DataMember(Name="hasDirtyElements", EmitDefaultValue=false)]
        public bool? HasDirtyElements { get; set; }

        /// <summary>
        /// Gets or Sets MostRecentBimInfo
        /// </summary>
        [DataMember(Name="mostRecentBimInfo", EmitDefaultValue=false)]
        public DateTime? MostRecentBimInfo { get; set; }

        /// <summary>
        /// Gets or Sets GeoLatitude
        /// </summary>
        [DataMember(Name="geoLatitude", EmitDefaultValue=false)]
        public double? GeoLatitude { get; set; }

        /// <summary>
        /// Gets or Sets GeoLongtitude
        /// </summary>
        [DataMember(Name="geoLongtitude", EmitDefaultValue=false)]
        public double? GeoLongtitude { get; set; }

        /// <summary>
        /// Gets or Sets PhaseType
        /// </summary>
        [DataMember(Name="phaseType", EmitDefaultValue=false)]
        public Guid? PhaseType { get; set; }

        /// <summary>
        /// Gets or Sets ClassificationType
        /// </summary>
        [DataMember(Name="classificationType", EmitDefaultValue=false)]
        public Guid? ClassificationType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildingResponse {\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  CadastralDesignation: ").Append(CadastralDesignation).Append("\n");
            sb.Append("  CadastralArea: ").Append(CadastralArea).Append("\n");
            sb.Append("  Parcelnumber: ").Append(Parcelnumber).Append("\n");
            sb.Append("  PublicLawRestriction: ").Append(PublicLawRestriction).Append("\n");
            sb.Append("  CompletionDate: ").Append(CompletionDate).Append("\n");
            sb.Append("  LastRenovationDate: ").Append(LastRenovationDate).Append("\n");
            sb.Append("  AddressStreet: ").Append(AddressStreet).Append("\n");
            sb.Append("  AddressHousenumber: ").Append(AddressHousenumber).Append("\n");
            sb.Append("  AddressHousenumberAddition: ").Append(AddressHousenumberAddition).Append("\n");
            sb.Append("  AddressZipcode: ").Append(AddressZipcode).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
            sb.Append("  BuildingUsage: ").Append(BuildingUsage).Append("\n");
            sb.Append("  GrossSurfaceArea: ").Append(GrossSurfaceArea).Append("\n");
            sb.Append("  EnergyLabel: ").Append(EnergyLabel).Append("\n");
            sb.Append("  EnergyPerformanceCoefficient: ").Append(EnergyPerformanceCoefficient).Append("\n");
            sb.Append("  EnergyIndex: ").Append(EnergyIndex).Append("\n");
            sb.Append("  ExpectedLifespan: ").Append(ExpectedLifespan).Append("\n");
            sb.Append("  ExpectedLifespanStructure: ").Append(ExpectedLifespanStructure).Append("\n");
            sb.Append("  ExpectedLifespanSkin: ").Append(ExpectedLifespanSkin).Append("\n");
            sb.Append("  ExpectedLifespanServices: ").Append(ExpectedLifespanServices).Append("\n");
            sb.Append("  ExpectedLifespanSpacePlan: ").Append(ExpectedLifespanSpacePlan).Append("\n");
            sb.Append("  ExpectedLifespanStuff: ").Append(ExpectedLifespanStuff).Append("\n");
            sb.Append("  BreeamLabel: ").Append(BreeamLabel).Append("\n");
            sb.Append("  GprLabel: ").Append(GprLabel).Append("\n");
            sb.Append("  MpgLabel: ").Append(MpgLabel).Append("\n");
            sb.Append("  MpgLabelManual: ").Append(MpgLabelManual).Append("\n");
            sb.Append("  MpgLabelIndicative: ").Append(MpgLabelIndicative).Append("\n");
            sb.Append("  LeedLabel: ").Append(LeedLabel).Append("\n");
            sb.Append("  IsDirty: ").Append(IsDirty).Append("\n");
            sb.Append("  HasDirtyElements: ").Append(HasDirtyElements).Append("\n");
            sb.Append("  MostRecentBimInfo: ").Append(MostRecentBimInfo).Append("\n");
            sb.Append("  GeoLatitude: ").Append(GeoLatitude).Append("\n");
            sb.Append("  GeoLongtitude: ").Append(GeoLongtitude).Append("\n");
            sb.Append("  PhaseType: ").Append(PhaseType).Append("\n");
            sb.Append("  ClassificationType: ").Append(ClassificationType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as BuildingResponse);
        }

        /// <summary>
        /// Returns true if BuildingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.CadastralDesignation == input.CadastralDesignation ||
                    (this.CadastralDesignation != null &&
                    this.CadastralDesignation.Equals(input.CadastralDesignation))
                ) && 
                (
                    this.CadastralArea == input.CadastralArea ||
                    (this.CadastralArea != null &&
                    this.CadastralArea.Equals(input.CadastralArea))
                ) && 
                (
                    this.Parcelnumber == input.Parcelnumber ||
                    (this.Parcelnumber != null &&
                    this.Parcelnumber.Equals(input.Parcelnumber))
                ) && 
                (
                    this.PublicLawRestriction == input.PublicLawRestriction ||
                    (this.PublicLawRestriction != null &&
                    this.PublicLawRestriction.Equals(input.PublicLawRestriction))
                ) && 
                (
                    this.CompletionDate == input.CompletionDate ||
                    (this.CompletionDate != null &&
                    this.CompletionDate.Equals(input.CompletionDate))
                ) && 
                (
                    this.LastRenovationDate == input.LastRenovationDate ||
                    (this.LastRenovationDate != null &&
                    this.LastRenovationDate.Equals(input.LastRenovationDate))
                ) && 
                (
                    this.AddressStreet == input.AddressStreet ||
                    (this.AddressStreet != null &&
                    this.AddressStreet.Equals(input.AddressStreet))
                ) && 
                (
                    this.AddressHousenumber == input.AddressHousenumber ||
                    (this.AddressHousenumber != null &&
                    this.AddressHousenumber.Equals(input.AddressHousenumber))
                ) && 
                (
                    this.AddressHousenumberAddition == input.AddressHousenumberAddition ||
                    (this.AddressHousenumberAddition != null &&
                    this.AddressHousenumberAddition.Equals(input.AddressHousenumberAddition))
                ) && 
                (
                    this.AddressZipcode == input.AddressZipcode ||
                    (this.AddressZipcode != null &&
                    this.AddressZipcode.Equals(input.AddressZipcode))
                ) && 
                (
                    this.AddressCity == input.AddressCity ||
                    (this.AddressCity != null &&
                    this.AddressCity.Equals(input.AddressCity))
                ) && 
                (
                    this.AddressCountry == input.AddressCountry ||
                    (this.AddressCountry != null &&
                    this.AddressCountry.Equals(input.AddressCountry))
                ) && 
                (
                    this.BuildingUsage == input.BuildingUsage ||
                    (this.BuildingUsage != null &&
                    this.BuildingUsage.Equals(input.BuildingUsage))
                ) && 
                (
                    this.GrossSurfaceArea == input.GrossSurfaceArea ||
                    (this.GrossSurfaceArea != null &&
                    this.GrossSurfaceArea.Equals(input.GrossSurfaceArea))
                ) && 
                (
                    this.EnergyLabel == input.EnergyLabel ||
                    (this.EnergyLabel != null &&
                    this.EnergyLabel.Equals(input.EnergyLabel))
                ) && 
                (
                    this.EnergyPerformanceCoefficient == input.EnergyPerformanceCoefficient ||
                    (this.EnergyPerformanceCoefficient != null &&
                    this.EnergyPerformanceCoefficient.Equals(input.EnergyPerformanceCoefficient))
                ) && 
                (
                    this.EnergyIndex == input.EnergyIndex ||
                    (this.EnergyIndex != null &&
                    this.EnergyIndex.Equals(input.EnergyIndex))
                ) && 
                (
                    this.ExpectedLifespan == input.ExpectedLifespan ||
                    (this.ExpectedLifespan != null &&
                    this.ExpectedLifespan.Equals(input.ExpectedLifespan))
                ) && 
                (
                    this.ExpectedLifespanStructure == input.ExpectedLifespanStructure ||
                    (this.ExpectedLifespanStructure != null &&
                    this.ExpectedLifespanStructure.Equals(input.ExpectedLifespanStructure))
                ) && 
                (
                    this.ExpectedLifespanSkin == input.ExpectedLifespanSkin ||
                    (this.ExpectedLifespanSkin != null &&
                    this.ExpectedLifespanSkin.Equals(input.ExpectedLifespanSkin))
                ) && 
                (
                    this.ExpectedLifespanServices == input.ExpectedLifespanServices ||
                    (this.ExpectedLifespanServices != null &&
                    this.ExpectedLifespanServices.Equals(input.ExpectedLifespanServices))
                ) && 
                (
                    this.ExpectedLifespanSpacePlan == input.ExpectedLifespanSpacePlan ||
                    (this.ExpectedLifespanSpacePlan != null &&
                    this.ExpectedLifespanSpacePlan.Equals(input.ExpectedLifespanSpacePlan))
                ) && 
                (
                    this.ExpectedLifespanStuff == input.ExpectedLifespanStuff ||
                    (this.ExpectedLifespanStuff != null &&
                    this.ExpectedLifespanStuff.Equals(input.ExpectedLifespanStuff))
                ) && 
                (
                    this.BreeamLabel == input.BreeamLabel ||
                    (this.BreeamLabel != null &&
                    this.BreeamLabel.Equals(input.BreeamLabel))
                ) && 
                (
                    this.GprLabel == input.GprLabel ||
                    (this.GprLabel != null &&
                    this.GprLabel.Equals(input.GprLabel))
                ) && 
                (
                    this.MpgLabel == input.MpgLabel ||
                    (this.MpgLabel != null &&
                    this.MpgLabel.Equals(input.MpgLabel))
                ) && 
                (
                    this.MpgLabelManual == input.MpgLabelManual ||
                    (this.MpgLabelManual != null &&
                    this.MpgLabelManual.Equals(input.MpgLabelManual))
                ) && 
                (
                    this.MpgLabelIndicative == input.MpgLabelIndicative ||
                    (this.MpgLabelIndicative != null &&
                    this.MpgLabelIndicative.Equals(input.MpgLabelIndicative))
                ) && 
                (
                    this.LeedLabel == input.LeedLabel ||
                    (this.LeedLabel != null &&
                    this.LeedLabel.Equals(input.LeedLabel))
                ) && 
                (
                    this.IsDirty == input.IsDirty ||
                    (this.IsDirty != null &&
                    this.IsDirty.Equals(input.IsDirty))
                ) && 
                (
                    this.HasDirtyElements == input.HasDirtyElements ||
                    (this.HasDirtyElements != null &&
                    this.HasDirtyElements.Equals(input.HasDirtyElements))
                ) && 
                (
                    this.MostRecentBimInfo == input.MostRecentBimInfo ||
                    (this.MostRecentBimInfo != null &&
                    this.MostRecentBimInfo.Equals(input.MostRecentBimInfo))
                ) && 
                (
                    this.GeoLatitude == input.GeoLatitude ||
                    (this.GeoLatitude != null &&
                    this.GeoLatitude.Equals(input.GeoLatitude))
                ) && 
                (
                    this.GeoLongtitude == input.GeoLongtitude ||
                    (this.GeoLongtitude != null &&
                    this.GeoLongtitude.Equals(input.GeoLongtitude))
                ) && 
                (
                    this.PhaseType == input.PhaseType ||
                    (this.PhaseType != null &&
                    this.PhaseType.Equals(input.PhaseType))
                ) && 
                (
                    this.ClassificationType == input.ClassificationType ||
                    (this.ClassificationType != null &&
                    this.ClassificationType.Equals(input.ClassificationType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.PortfolioId != null)
                    hashCode = hashCode * 59 + this.PortfolioId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.CadastralDesignation != null)
                    hashCode = hashCode * 59 + this.CadastralDesignation.GetHashCode();
                if (this.CadastralArea != null)
                    hashCode = hashCode * 59 + this.CadastralArea.GetHashCode();
                if (this.Parcelnumber != null)
                    hashCode = hashCode * 59 + this.Parcelnumber.GetHashCode();
                if (this.PublicLawRestriction != null)
                    hashCode = hashCode * 59 + this.PublicLawRestriction.GetHashCode();
                if (this.CompletionDate != null)
                    hashCode = hashCode * 59 + this.CompletionDate.GetHashCode();
                if (this.LastRenovationDate != null)
                    hashCode = hashCode * 59 + this.LastRenovationDate.GetHashCode();
                if (this.AddressStreet != null)
                    hashCode = hashCode * 59 + this.AddressStreet.GetHashCode();
                if (this.AddressHousenumber != null)
                    hashCode = hashCode * 59 + this.AddressHousenumber.GetHashCode();
                if (this.AddressHousenumberAddition != null)
                    hashCode = hashCode * 59 + this.AddressHousenumberAddition.GetHashCode();
                if (this.AddressZipcode != null)
                    hashCode = hashCode * 59 + this.AddressZipcode.GetHashCode();
                if (this.AddressCity != null)
                    hashCode = hashCode * 59 + this.AddressCity.GetHashCode();
                if (this.AddressCountry != null)
                    hashCode = hashCode * 59 + this.AddressCountry.GetHashCode();
                if (this.BuildingUsage != null)
                    hashCode = hashCode * 59 + this.BuildingUsage.GetHashCode();
                if (this.GrossSurfaceArea != null)
                    hashCode = hashCode * 59 + this.GrossSurfaceArea.GetHashCode();
                if (this.EnergyLabel != null)
                    hashCode = hashCode * 59 + this.EnergyLabel.GetHashCode();
                if (this.EnergyPerformanceCoefficient != null)
                    hashCode = hashCode * 59 + this.EnergyPerformanceCoefficient.GetHashCode();
                if (this.EnergyIndex != null)
                    hashCode = hashCode * 59 + this.EnergyIndex.GetHashCode();
                if (this.ExpectedLifespan != null)
                    hashCode = hashCode * 59 + this.ExpectedLifespan.GetHashCode();
                if (this.ExpectedLifespanStructure != null)
                    hashCode = hashCode * 59 + this.ExpectedLifespanStructure.GetHashCode();
                if (this.ExpectedLifespanSkin != null)
                    hashCode = hashCode * 59 + this.ExpectedLifespanSkin.GetHashCode();
                if (this.ExpectedLifespanServices != null)
                    hashCode = hashCode * 59 + this.ExpectedLifespanServices.GetHashCode();
                if (this.ExpectedLifespanSpacePlan != null)
                    hashCode = hashCode * 59 + this.ExpectedLifespanSpacePlan.GetHashCode();
                if (this.ExpectedLifespanStuff != null)
                    hashCode = hashCode * 59 + this.ExpectedLifespanStuff.GetHashCode();
                if (this.BreeamLabel != null)
                    hashCode = hashCode * 59 + this.BreeamLabel.GetHashCode();
                if (this.GprLabel != null)
                    hashCode = hashCode * 59 + this.GprLabel.GetHashCode();
                if (this.MpgLabel != null)
                    hashCode = hashCode * 59 + this.MpgLabel.GetHashCode();
                if (this.MpgLabelManual != null)
                    hashCode = hashCode * 59 + this.MpgLabelManual.GetHashCode();
                if (this.MpgLabelIndicative != null)
                    hashCode = hashCode * 59 + this.MpgLabelIndicative.GetHashCode();
                if (this.LeedLabel != null)
                    hashCode = hashCode * 59 + this.LeedLabel.GetHashCode();
                if (this.IsDirty != null)
                    hashCode = hashCode * 59 + this.IsDirty.GetHashCode();
                if (this.HasDirtyElements != null)
                    hashCode = hashCode * 59 + this.HasDirtyElements.GetHashCode();
                if (this.MostRecentBimInfo != null)
                    hashCode = hashCode * 59 + this.MostRecentBimInfo.GetHashCode();
                if (this.GeoLatitude != null)
                    hashCode = hashCode * 59 + this.GeoLatitude.GetHashCode();
                if (this.GeoLongtitude != null)
                    hashCode = hashCode * 59 + this.GeoLongtitude.GetHashCode();
                if (this.PhaseType != null)
                    hashCode = hashCode * 59 + this.PhaseType.GetHashCode();
                if (this.ClassificationType != null)
                    hashCode = hashCode * 59 + this.ClassificationType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
