//HintName: G.Models.BuildMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Afi2,
        /// <summary>
        /// 
        /// </summary>
        Align,
        /// <summary>
        /// 
        /// </summary>
        BedlamCliff,
        /// <summary>
        /// 
        /// </summary>
        Export,
        /// <summary>
        /// 
        /// </summary>
        ExportBlender,
        /// <summary>
        /// 
        /// </summary>
        ExportGloss,
        /// <summary>
        /// 
        /// </summary>
        FromBetas,
        /// <summary>
        /// 
        /// </summary>
        FromImages,
        /// <summary>
        /// 
        /// </summary>
        FromMeasurements,
        /// <summary>
        /// 
        /// </summary>
        FromScans,
        /// <summary>
        /// 
        /// </summary>
        FromSmpl,
        /// <summary>
        /// 
        /// </summary>
        FromSmplMotion,
        /// <summary>
        /// 
        /// </summary>
        FromSmplPose,
        /// <summary>
        /// 
        /// </summary>
        FromVideo,
        /// <summary>
        /// 
        /// </summary>
        Ingest,
        /// <summary>
        /// 
        /// </summary>
        Measure,
        /// <summary>
        /// 
        /// </summary>
        MotionBlend,
        /// <summary>
        /// 
        /// </summary>
        Regress,
        /// <summary>
        /// 
        /// </summary>
        Render,
        /// <summary>
        /// 
        /// </summary>
        SearchMotions,
        /// <summary>
        /// 
        /// </summary>
        Shapy,
        /// <summary>
        /// 
        /// </summary>
        Update,
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildMethod value)
        {
            return value switch
            {
                BuildMethod.Afi2 => "AFI2",
                BuildMethod.Align => "ALIGN",
                BuildMethod.BedlamCliff => "BEDLAM_CLIFF",
                BuildMethod.Export => "EXPORT",
                BuildMethod.ExportBlender => "EXPORT_BLENDER",
                BuildMethod.ExportGloss => "EXPORT_GLOSS",
                BuildMethod.FromBetas => "FROM_BETAS",
                BuildMethod.FromImages => "FROM_IMAGES",
                BuildMethod.FromMeasurements => "FROM_MEASUREMENTS",
                BuildMethod.FromScans => "FROM_SCANS",
                BuildMethod.FromSmpl => "FROM_SMPL",
                BuildMethod.FromSmplMotion => "FROM_SMPL_MOTION",
                BuildMethod.FromSmplPose => "FROM_SMPL_POSE",
                BuildMethod.FromVideo => "FROM_VIDEO",
                BuildMethod.Ingest => "INGEST",
                BuildMethod.Measure => "MEASURE",
                BuildMethod.MotionBlend => "MOTION_BLEND",
                BuildMethod.Regress => "REGRESS",
                BuildMethod.Render => "RENDER",
                BuildMethod.SearchMotions => "SEARCH_MOTIONS",
                BuildMethod.Shapy => "SHAPY",
                BuildMethod.Update => "UPDATE",
                BuildMethod.Upload => "UPLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildMethod? ToEnum(string value)
        {
            return value switch
            {
                "AFI2" => BuildMethod.Afi2,
                "ALIGN" => BuildMethod.Align,
                "BEDLAM_CLIFF" => BuildMethod.BedlamCliff,
                "EXPORT" => BuildMethod.Export,
                "EXPORT_BLENDER" => BuildMethod.ExportBlender,
                "EXPORT_GLOSS" => BuildMethod.ExportGloss,
                "FROM_BETAS" => BuildMethod.FromBetas,
                "FROM_IMAGES" => BuildMethod.FromImages,
                "FROM_MEASUREMENTS" => BuildMethod.FromMeasurements,
                "FROM_SCANS" => BuildMethod.FromScans,
                "FROM_SMPL" => BuildMethod.FromSmpl,
                "FROM_SMPL_MOTION" => BuildMethod.FromSmplMotion,
                "FROM_SMPL_POSE" => BuildMethod.FromSmplPose,
                "FROM_VIDEO" => BuildMethod.FromVideo,
                "INGEST" => BuildMethod.Ingest,
                "MEASURE" => BuildMethod.Measure,
                "MOTION_BLEND" => BuildMethod.MotionBlend,
                "REGRESS" => BuildMethod.Regress,
                "RENDER" => BuildMethod.Render,
                "SEARCH_MOTIONS" => BuildMethod.SearchMotions,
                "SHAPY" => BuildMethod.Shapy,
                "UPDATE" => BuildMethod.Update,
                "UPLOAD" => BuildMethod.Upload,
                _ => null,
            };
        }
    }
}