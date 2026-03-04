//HintName: G.Models.PipelinePublicServiceListPipelinesView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceListPipelinesView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        ViewFull,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_RECIPE")]
        ViewRecipe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceListPipelinesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListPipelinesView value)
        {
            return value switch
            {
                PipelinePublicServiceListPipelinesView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceListPipelinesView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceListPipelinesView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListPipelinesView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListPipelinesView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceListPipelinesView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceListPipelinesView.ViewRecipe,
                _ => null,
            };
        }
    }
}