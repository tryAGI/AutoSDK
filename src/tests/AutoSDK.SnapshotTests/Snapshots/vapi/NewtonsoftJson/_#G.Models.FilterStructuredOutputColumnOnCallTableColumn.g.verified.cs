//HintName: G.Models.FilterStructuredOutputColumnOnCallTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.<br/>
    /// Structured Output Type columns are only to filter on artifact.structuredOutputs[OutputID] column.<br/>
    /// Example: artifact.structuredOutputs[OutputID]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterStructuredOutputColumnOnCallTableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact.structuredOutputs[OutputID]")]
        ArtifactStructuredOutputsOutputID,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterStructuredOutputColumnOnCallTableColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterStructuredOutputColumnOnCallTableColumn value)
        {
            return value switch
            {
                FilterStructuredOutputColumnOnCallTableColumn.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterStructuredOutputColumnOnCallTableColumn? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => FilterStructuredOutputColumnOnCallTableColumn.ArtifactStructuredOutputsOutputID,
                _ => null,
            };
        }
    }
}