//HintName: G.Models.PipelineVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility defines who can access the pipeline.<br/>
    ///  - VISIBILITY_PRIVATE: Only the user can see the pipeline.<br/>
    ///  - VISIBILITY_PUBLIC: Other users can see the pipeline.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineVisibility
    {
        /// <summary>
        /// Only the user can see the pipeline.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PRIVATE")]
        VISIBILITYPRIVATE,
        /// <summary>
        /// Other users can see the pipeline.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PUBLIC")]
        VISIBILITYPUBLIC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineVisibility value)
        {
            return value switch
            {
                PipelineVisibility.VISIBILITYPRIVATE => "VISIBILITY_PRIVATE",
                PipelineVisibility.VISIBILITYPUBLIC => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => PipelineVisibility.VISIBILITYPRIVATE,
                "VISIBILITY_PUBLIC" => PipelineVisibility.VISIBILITYPUBLIC,
                _ => null,
            };
        }
    }
}