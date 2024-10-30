//HintName: G.Models.PipelineView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// View defines how a Pipeline is presented.<br/>
    ///  - VIEW_BASIC: Default view, only includes basic information.<br/>
    ///  - VIEW_FULL: Full representation.<br/>
    ///  - VIEW_RECIPE: Contains the recipe of the resource.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelineView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        VIEWFULL,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_RECIPE")]
        VIEWRECIPE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineView value)
        {
            return value switch
            {
                PipelineView.VIEWBASIC => "VIEW_BASIC",
                PipelineView.VIEWFULL => "VIEW_FULL",
                PipelineView.VIEWRECIPE => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelineView.VIEWBASIC,
                "VIEW_FULL" => PipelineView.VIEWFULL,
                "VIEW_RECIPE" => PipelineView.VIEWRECIPE,
                _ => null,
            };
        }
    }
}