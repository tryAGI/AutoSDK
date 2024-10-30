//HintName: G.Models.PipelinePublicServiceListComponentDefinitionsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceListComponentDefinitionsView
    {
        /// <summary>
        /// Default view, only includes basic information (removes the `spec`
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceListComponentDefinitionsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListComponentDefinitionsView value)
        {
            return value switch
            {
                PipelinePublicServiceListComponentDefinitionsView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceListComponentDefinitionsView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListComponentDefinitionsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListComponentDefinitionsView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceListComponentDefinitionsView.VIEWFULL,
                _ => null,
            };
        }
    }
}