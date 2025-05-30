// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Chefs.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class NutritionData : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The carbs property</summary>
        public double? Carbs { get; private set; }
        /// <summary>The carbsBase property</summary>
        public double? CarbsBase { get; private set; }
        /// <summary>The fat property</summary>
        public double? Fat { get; private set; }
        /// <summary>The fatBase property</summary>
        public double? FatBase { get; private set; }
        /// <summary>The protein property</summary>
        public double? Protein { get; private set; }
        /// <summary>The proteinBase property</summary>
        public double? ProteinBase { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Chefs.Client.Models.NutritionData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Chefs.Client.Models.NutritionData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Chefs.Client.Models.NutritionData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "carbs", n => { Carbs = n.GetDoubleValue(); } },
                { "carbsBase", n => { CarbsBase = n.GetDoubleValue(); } },
                { "fat", n => { Fat = n.GetDoubleValue(); } },
                { "fatBase", n => { FatBase = n.GetDoubleValue(); } },
                { "protein", n => { Protein = n.GetDoubleValue(); } },
                { "proteinBase", n => { ProteinBase = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}
#pragma warning restore CS0618
