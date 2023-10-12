//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>The area on a single floor occupied by the core. </summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CoreArea : SpaceBoundary
    {
        [JsonConstructor]
        public CoreArea(System.Guid @core, Profile @boundary, IList<Polygon> @cells, double @area, double? @length, double? @depth, double @height, string @programGroup, string @programType, System.Guid? @programRequirement, System.Guid? @level, System.Guid? @levelLayout, string @hyparSpaceType, Transform @transform, Material @material, Representation @representation, bool @isElementDefinition, System.Guid @id, string @name)
            : base(boundary, cells, area, length, depth, height, programGroup, programType, programRequirement, level, levelLayout, hyparSpaceType, transform, material, representation, isElementDefinition, id, name)
        {
            this.Core = @core;
            }
        
        
        // Empty constructor
        public CoreArea()
            : base()
        {
        }
    
        /// <summary>The core this area belongs to.</summary>
        [JsonProperty("Core", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Core { get; set; }
    
    
    }
}