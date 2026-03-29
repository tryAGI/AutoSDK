//HintName: G.Models.JSONQueryOnCallTableWithStructuredOutputColumnColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column that will be queried in the call table.<br/>
    /// Structured Output Type columns are only to query on artifact.structuredOutputs[OutputID] column.<br/>
    /// Example: artifact.structuredOutputs[OutputID]
    /// </summary>
    public enum JSONQueryOnCallTableWithStructuredOutputColumnColumn
    {
        /// <summary>
        /// 
        /// </summary>
        ArtifactStructuredOutputsOutputID,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithStructuredOutputColumnColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithStructuredOutputColumnColumn value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithStructuredOutputColumnColumn.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithStructuredOutputColumnColumn? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => JSONQueryOnCallTableWithStructuredOutputColumnColumn.ArtifactStructuredOutputsOutputID,
                _ => null,
            };
        }
    }
}