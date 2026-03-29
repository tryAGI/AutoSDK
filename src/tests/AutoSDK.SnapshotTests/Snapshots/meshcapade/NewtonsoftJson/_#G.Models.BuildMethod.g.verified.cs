//HintName: G.Models.BuildMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BuildMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AFI2")]
        Afi2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALIGN")]
        Align,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEDLAM_CLIFF")]
        BedlamCliff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXPORT")]
        Export,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXPORT_BLENDER")]
        ExportBlender,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXPORT_GLOSS")]
        ExportGloss,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_BETAS")]
        FromBetas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_IMAGES")]
        FromImages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_MEASUREMENTS")]
        FromMeasurements,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_SCANS")]
        FromScans,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_SMPL")]
        FromSmpl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_SMPL_MOTION")]
        FromSmplMotion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_SMPL_POSE")]
        FromSmplPose,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROM_VIDEO")]
        FromVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INGEST")]
        Ingest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEASURE")]
        Measure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MOTION_BLEND")]
        MotionBlend,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REGRESS")]
        Regress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RENDER")]
        Render,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SEARCH_MOTIONS")]
        SearchMotions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SHAPY")]
        Shapy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPDATE")]
        Update,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UPLOAD")]
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