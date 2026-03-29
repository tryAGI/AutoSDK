//HintName: G.Models.ExtractV2ParametersExtractionTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Granularity of extraction: per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row<br/>
    /// Default Value: per_doc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractV2ParametersExtractionTarget
    {
        /// <summary>
        /// per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="per_doc")]
        PerDoc,
        /// <summary>
        /// per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="per_page")]
        PerPage,
        /// <summary>
        /// per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="per_table_row")]
        PerTableRow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractV2ParametersExtractionTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractV2ParametersExtractionTarget value)
        {
            return value switch
            {
                ExtractV2ParametersExtractionTarget.PerDoc => "per_doc",
                ExtractV2ParametersExtractionTarget.PerPage => "per_page",
                ExtractV2ParametersExtractionTarget.PerTableRow => "per_table_row",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractV2ParametersExtractionTarget? ToEnum(string value)
        {
            return value switch
            {
                "per_doc" => ExtractV2ParametersExtractionTarget.PerDoc,
                "per_page" => ExtractV2ParametersExtractionTarget.PerPage,
                "per_table_row" => ExtractV2ParametersExtractionTarget.PerTableRow,
                _ => null,
            };
        }
    }
}