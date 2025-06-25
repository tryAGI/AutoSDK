﻿//HintName: G.Models.PipelinePublicServiceGetNamespacePipelineView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceGetNamespacePipelineView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        VIEWFULL,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        VIEWRECIPE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceGetNamespacePipelineViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetNamespacePipelineView value)
        {
            return value switch
            {
                PipelinePublicServiceGetNamespacePipelineView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceGetNamespacePipelineView.VIEWFULL => "VIEW_FULL",
                PipelinePublicServiceGetNamespacePipelineView.VIEWRECIPE => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetNamespacePipelineView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetNamespacePipelineView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceGetNamespacePipelineView.VIEWFULL,
                "VIEW_RECIPE" => PipelinePublicServiceGetNamespacePipelineView.VIEWRECIPE,
                _ => null,
            };
        }
    }
}