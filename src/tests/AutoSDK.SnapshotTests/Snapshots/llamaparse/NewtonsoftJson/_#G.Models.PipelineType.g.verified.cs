//HintName: G.Models.PipelineType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for representing the type of a pipeline
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANAGED")]
        Managed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PLAYGROUND")]
        Playground,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineType value)
        {
            return value switch
            {
                PipelineType.Managed => "MANAGED",
                PipelineType.Playground => "PLAYGROUND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineType? ToEnum(string value)
        {
            return value switch
            {
                "MANAGED" => PipelineType.Managed,
                "PLAYGROUND" => PipelineType.Playground,
                _ => null,
            };
        }
    }
}