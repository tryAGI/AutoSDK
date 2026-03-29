//HintName: G.Models.JSONQueryOnCallTableWithStringTypeColumnColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column that will be queried in the selected table.<br/>
    /// Available columns depend on the selected table.<br/>
    /// String Type columns are columns where the rows store String data<br/>
    /// Example: id
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnCallTableWithStringTypeColumnColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact.structuredOutputs[OutputID]")]
        ArtifactStructuredOutputsOutputID,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithStringTypeColumnColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithStringTypeColumnColumn value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithStringTypeColumnColumn.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                JSONQueryOnCallTableWithStringTypeColumnColumn.Id => "id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithStringTypeColumnColumn? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => JSONQueryOnCallTableWithStringTypeColumnColumn.ArtifactStructuredOutputsOutputID,
                "id" => JSONQueryOnCallTableWithStringTypeColumnColumn.Id,
                _ => null,
            };
        }
    }
}