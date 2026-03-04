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
    public enum PipelineView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        ViewRecipe,
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
                PipelineView.ViewBasic => "VIEW_BASIC",
                PipelineView.ViewFull => "VIEW_FULL",
                PipelineView.ViewRecipe => "VIEW_RECIPE",
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
                "VIEW_BASIC" => PipelineView.ViewBasic,
                "VIEW_FULL" => PipelineView.ViewFull,
                "VIEW_RECIPE" => PipelineView.ViewRecipe,
                _ => null,
            };
        }
    }
}