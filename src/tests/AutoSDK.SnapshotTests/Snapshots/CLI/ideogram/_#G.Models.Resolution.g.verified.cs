//HintName: G.Models.Resolution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (For model_version for 2.0 only, cannot be used in conjunction with aspect_ratio) The resolution to use for image generation, represented in width x height. If not specified, defaults to using aspect_ratio.<br/>
    /// Example: RESOLUTION_1024_1024
    /// </summary>
    public enum Resolution
    {
        /// <summary>
        /// 
        /// </summary>
        x5121536,
        /// <summary>
        /// 
        /// </summary>
        x5761408,
        /// <summary>
        /// 
        /// </summary>
        x5761472,
        /// <summary>
        /// 
        /// </summary>
        x5761536,
        /// <summary>
        /// 
        /// </summary>
        x6401024,
        /// <summary>
        /// 
        /// </summary>
        x6401344,
        /// <summary>
        /// 
        /// </summary>
        x6401408,
        /// <summary>
        /// 
        /// </summary>
        x6401472,
        /// <summary>
        /// 
        /// </summary>
        x6401536,
        /// <summary>
        /// 
        /// </summary>
        x7041152,
        /// <summary>
        /// 
        /// </summary>
        x7041216,
        /// <summary>
        /// 
        /// </summary>
        x7041280,
        /// <summary>
        /// 
        /// </summary>
        x7041344,
        /// <summary>
        /// 
        /// </summary>
        x7041408,
        /// <summary>
        /// 
        /// </summary>
        x7041472,
        /// <summary>
        /// 
        /// </summary>
        x7201280,
        /// <summary>
        /// 
        /// </summary>
        x7361312,
        /// <summary>
        /// 
        /// </summary>
        x7681024,
        /// <summary>
        /// 
        /// </summary>
        x7681088,
        /// <summary>
        /// 
        /// </summary>
        x7681152,
        /// <summary>
        /// 
        /// </summary>
        x7681216,
        /// <summary>
        /// 
        /// </summary>
        x7681232,
        /// <summary>
        /// 
        /// </summary>
        x7681280,
        /// <summary>
        /// 
        /// </summary>
        x7681344,
        /// <summary>
        /// 
        /// </summary>
        x832960,
        /// <summary>
        /// 
        /// </summary>
        x8321024,
        /// <summary>
        /// 
        /// </summary>
        x8321088,
        /// <summary>
        /// 
        /// </summary>
        x8321152,
        /// <summary>
        /// 
        /// </summary>
        x8321216,
        /// <summary>
        /// 
        /// </summary>
        x8321248,
        /// <summary>
        /// 
        /// </summary>
        x8641152,
        /// <summary>
        /// 
        /// </summary>
        x896960,
        /// <summary>
        /// 
        /// </summary>
        x8961024,
        /// <summary>
        /// 
        /// </summary>
        x8961088,
        /// <summary>
        /// 
        /// </summary>
        x8961120,
        /// <summary>
        /// 
        /// </summary>
        x8961152,
        /// <summary>
        /// 
        /// </summary>
        x960832,
        /// <summary>
        /// 
        /// </summary>
        x960896,
        /// <summary>
        /// 
        /// </summary>
        x9601024,
        /// <summary>
        /// 
        /// </summary>
        x9601088,
        /// <summary>
        /// 
        /// </summary>
        x1024640,
        /// <summary>
        /// 
        /// </summary>
        x1024768,
        /// <summary>
        /// 
        /// </summary>
        x1024832,
        /// <summary>
        /// 
        /// </summary>
        x1024896,
        /// <summary>
        /// 
        /// </summary>
        x1024960,
        /// <summary>
        /// 
        /// </summary>
        x10241024,
        /// <summary>
        /// 
        /// </summary>
        x1088768,
        /// <summary>
        /// 
        /// </summary>
        x1088832,
        /// <summary>
        /// 
        /// </summary>
        x1088896,
        /// <summary>
        /// 
        /// </summary>
        x1088960,
        /// <summary>
        /// 
        /// </summary>
        x1120896,
        /// <summary>
        /// 
        /// </summary>
        x1152704,
        /// <summary>
        /// 
        /// </summary>
        x1152768,
        /// <summary>
        /// 
        /// </summary>
        x1152832,
        /// <summary>
        /// 
        /// </summary>
        x1152864,
        /// <summary>
        /// 
        /// </summary>
        x1152896,
        /// <summary>
        /// 
        /// </summary>
        x1216704,
        /// <summary>
        /// 
        /// </summary>
        x1216768,
        /// <summary>
        /// 
        /// </summary>
        x1216832,
        /// <summary>
        /// 
        /// </summary>
        x1232768,
        /// <summary>
        /// 
        /// </summary>
        x1248832,
        /// <summary>
        /// 
        /// </summary>
        x1280704,
        /// <summary>
        /// 
        /// </summary>
        x1280720,
        /// <summary>
        /// 
        /// </summary>
        x1280768,
        /// <summary>
        /// 
        /// </summary>
        x1280800,
        /// <summary>
        /// 
        /// </summary>
        x1312736,
        /// <summary>
        /// 
        /// </summary>
        x1344640,
        /// <summary>
        /// 
        /// </summary>
        x1344704,
        /// <summary>
        /// 
        /// </summary>
        x1344768,
        /// <summary>
        /// 
        /// </summary>
        x1408576,
        /// <summary>
        /// 
        /// </summary>
        x1408640,
        /// <summary>
        /// 
        /// </summary>
        x1408704,
        /// <summary>
        /// 
        /// </summary>
        x1472576,
        /// <summary>
        /// 
        /// </summary>
        x1472640,
        /// <summary>
        /// 
        /// </summary>
        x1472704,
        /// <summary>
        /// 
        /// </summary>
        x1536512,
        /// <summary>
        /// 
        /// </summary>
        x1536576,
        /// <summary>
        /// 
        /// </summary>
        x1536640,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Resolution value)
        {
            return value switch
            {
                Resolution.x5121536 => "RESOLUTION_512_1536",
                Resolution.x5761408 => "RESOLUTION_576_1408",
                Resolution.x5761472 => "RESOLUTION_576_1472",
                Resolution.x5761536 => "RESOLUTION_576_1536",
                Resolution.x6401024 => "RESOLUTION_640_1024",
                Resolution.x6401344 => "RESOLUTION_640_1344",
                Resolution.x6401408 => "RESOLUTION_640_1408",
                Resolution.x6401472 => "RESOLUTION_640_1472",
                Resolution.x6401536 => "RESOLUTION_640_1536",
                Resolution.x7041152 => "RESOLUTION_704_1152",
                Resolution.x7041216 => "RESOLUTION_704_1216",
                Resolution.x7041280 => "RESOLUTION_704_1280",
                Resolution.x7041344 => "RESOLUTION_704_1344",
                Resolution.x7041408 => "RESOLUTION_704_1408",
                Resolution.x7041472 => "RESOLUTION_704_1472",
                Resolution.x7201280 => "RESOLUTION_720_1280",
                Resolution.x7361312 => "RESOLUTION_736_1312",
                Resolution.x7681024 => "RESOLUTION_768_1024",
                Resolution.x7681088 => "RESOLUTION_768_1088",
                Resolution.x7681152 => "RESOLUTION_768_1152",
                Resolution.x7681216 => "RESOLUTION_768_1216",
                Resolution.x7681232 => "RESOLUTION_768_1232",
                Resolution.x7681280 => "RESOLUTION_768_1280",
                Resolution.x7681344 => "RESOLUTION_768_1344",
                Resolution.x832960 => "RESOLUTION_832_960",
                Resolution.x8321024 => "RESOLUTION_832_1024",
                Resolution.x8321088 => "RESOLUTION_832_1088",
                Resolution.x8321152 => "RESOLUTION_832_1152",
                Resolution.x8321216 => "RESOLUTION_832_1216",
                Resolution.x8321248 => "RESOLUTION_832_1248",
                Resolution.x8641152 => "RESOLUTION_864_1152",
                Resolution.x896960 => "RESOLUTION_896_960",
                Resolution.x8961024 => "RESOLUTION_896_1024",
                Resolution.x8961088 => "RESOLUTION_896_1088",
                Resolution.x8961120 => "RESOLUTION_896_1120",
                Resolution.x8961152 => "RESOLUTION_896_1152",
                Resolution.x960832 => "RESOLUTION_960_832",
                Resolution.x960896 => "RESOLUTION_960_896",
                Resolution.x9601024 => "RESOLUTION_960_1024",
                Resolution.x9601088 => "RESOLUTION_960_1088",
                Resolution.x1024640 => "RESOLUTION_1024_640",
                Resolution.x1024768 => "RESOLUTION_1024_768",
                Resolution.x1024832 => "RESOLUTION_1024_832",
                Resolution.x1024896 => "RESOLUTION_1024_896",
                Resolution.x1024960 => "RESOLUTION_1024_960",
                Resolution.x10241024 => "RESOLUTION_1024_1024",
                Resolution.x1088768 => "RESOLUTION_1088_768",
                Resolution.x1088832 => "RESOLUTION_1088_832",
                Resolution.x1088896 => "RESOLUTION_1088_896",
                Resolution.x1088960 => "RESOLUTION_1088_960",
                Resolution.x1120896 => "RESOLUTION_1120_896",
                Resolution.x1152704 => "RESOLUTION_1152_704",
                Resolution.x1152768 => "RESOLUTION_1152_768",
                Resolution.x1152832 => "RESOLUTION_1152_832",
                Resolution.x1152864 => "RESOLUTION_1152_864",
                Resolution.x1152896 => "RESOLUTION_1152_896",
                Resolution.x1216704 => "RESOLUTION_1216_704",
                Resolution.x1216768 => "RESOLUTION_1216_768",
                Resolution.x1216832 => "RESOLUTION_1216_832",
                Resolution.x1232768 => "RESOLUTION_1232_768",
                Resolution.x1248832 => "RESOLUTION_1248_832",
                Resolution.x1280704 => "RESOLUTION_1280_704",
                Resolution.x1280720 => "RESOLUTION_1280_720",
                Resolution.x1280768 => "RESOLUTION_1280_768",
                Resolution.x1280800 => "RESOLUTION_1280_800",
                Resolution.x1312736 => "RESOLUTION_1312_736",
                Resolution.x1344640 => "RESOLUTION_1344_640",
                Resolution.x1344704 => "RESOLUTION_1344_704",
                Resolution.x1344768 => "RESOLUTION_1344_768",
                Resolution.x1408576 => "RESOLUTION_1408_576",
                Resolution.x1408640 => "RESOLUTION_1408_640",
                Resolution.x1408704 => "RESOLUTION_1408_704",
                Resolution.x1472576 => "RESOLUTION_1472_576",
                Resolution.x1472640 => "RESOLUTION_1472_640",
                Resolution.x1472704 => "RESOLUTION_1472_704",
                Resolution.x1536512 => "RESOLUTION_1536_512",
                Resolution.x1536576 => "RESOLUTION_1536_576",
                Resolution.x1536640 => "RESOLUTION_1536_640",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Resolution? ToEnum(string value)
        {
            return value switch
            {
                "RESOLUTION_512_1536" => Resolution.x5121536,
                "RESOLUTION_576_1408" => Resolution.x5761408,
                "RESOLUTION_576_1472" => Resolution.x5761472,
                "RESOLUTION_576_1536" => Resolution.x5761536,
                "RESOLUTION_640_1024" => Resolution.x6401024,
                "RESOLUTION_640_1344" => Resolution.x6401344,
                "RESOLUTION_640_1408" => Resolution.x6401408,
                "RESOLUTION_640_1472" => Resolution.x6401472,
                "RESOLUTION_640_1536" => Resolution.x6401536,
                "RESOLUTION_704_1152" => Resolution.x7041152,
                "RESOLUTION_704_1216" => Resolution.x7041216,
                "RESOLUTION_704_1280" => Resolution.x7041280,
                "RESOLUTION_704_1344" => Resolution.x7041344,
                "RESOLUTION_704_1408" => Resolution.x7041408,
                "RESOLUTION_704_1472" => Resolution.x7041472,
                "RESOLUTION_720_1280" => Resolution.x7201280,
                "RESOLUTION_736_1312" => Resolution.x7361312,
                "RESOLUTION_768_1024" => Resolution.x7681024,
                "RESOLUTION_768_1088" => Resolution.x7681088,
                "RESOLUTION_768_1152" => Resolution.x7681152,
                "RESOLUTION_768_1216" => Resolution.x7681216,
                "RESOLUTION_768_1232" => Resolution.x7681232,
                "RESOLUTION_768_1280" => Resolution.x7681280,
                "RESOLUTION_768_1344" => Resolution.x7681344,
                "RESOLUTION_832_960" => Resolution.x832960,
                "RESOLUTION_832_1024" => Resolution.x8321024,
                "RESOLUTION_832_1088" => Resolution.x8321088,
                "RESOLUTION_832_1152" => Resolution.x8321152,
                "RESOLUTION_832_1216" => Resolution.x8321216,
                "RESOLUTION_832_1248" => Resolution.x8321248,
                "RESOLUTION_864_1152" => Resolution.x8641152,
                "RESOLUTION_896_960" => Resolution.x896960,
                "RESOLUTION_896_1024" => Resolution.x8961024,
                "RESOLUTION_896_1088" => Resolution.x8961088,
                "RESOLUTION_896_1120" => Resolution.x8961120,
                "RESOLUTION_896_1152" => Resolution.x8961152,
                "RESOLUTION_960_832" => Resolution.x960832,
                "RESOLUTION_960_896" => Resolution.x960896,
                "RESOLUTION_960_1024" => Resolution.x9601024,
                "RESOLUTION_960_1088" => Resolution.x9601088,
                "RESOLUTION_1024_640" => Resolution.x1024640,
                "RESOLUTION_1024_768" => Resolution.x1024768,
                "RESOLUTION_1024_832" => Resolution.x1024832,
                "RESOLUTION_1024_896" => Resolution.x1024896,
                "RESOLUTION_1024_960" => Resolution.x1024960,
                "RESOLUTION_1024_1024" => Resolution.x10241024,
                "RESOLUTION_1088_768" => Resolution.x1088768,
                "RESOLUTION_1088_832" => Resolution.x1088832,
                "RESOLUTION_1088_896" => Resolution.x1088896,
                "RESOLUTION_1088_960" => Resolution.x1088960,
                "RESOLUTION_1120_896" => Resolution.x1120896,
                "RESOLUTION_1152_704" => Resolution.x1152704,
                "RESOLUTION_1152_768" => Resolution.x1152768,
                "RESOLUTION_1152_832" => Resolution.x1152832,
                "RESOLUTION_1152_864" => Resolution.x1152864,
                "RESOLUTION_1152_896" => Resolution.x1152896,
                "RESOLUTION_1216_704" => Resolution.x1216704,
                "RESOLUTION_1216_768" => Resolution.x1216768,
                "RESOLUTION_1216_832" => Resolution.x1216832,
                "RESOLUTION_1232_768" => Resolution.x1232768,
                "RESOLUTION_1248_832" => Resolution.x1248832,
                "RESOLUTION_1280_704" => Resolution.x1280704,
                "RESOLUTION_1280_720" => Resolution.x1280720,
                "RESOLUTION_1280_768" => Resolution.x1280768,
                "RESOLUTION_1280_800" => Resolution.x1280800,
                "RESOLUTION_1312_736" => Resolution.x1312736,
                "RESOLUTION_1344_640" => Resolution.x1344640,
                "RESOLUTION_1344_704" => Resolution.x1344704,
                "RESOLUTION_1344_768" => Resolution.x1344768,
                "RESOLUTION_1408_576" => Resolution.x1408576,
                "RESOLUTION_1408_640" => Resolution.x1408640,
                "RESOLUTION_1408_704" => Resolution.x1408704,
                "RESOLUTION_1472_576" => Resolution.x1472576,
                "RESOLUTION_1472_640" => Resolution.x1472640,
                "RESOLUTION_1472_704" => Resolution.x1472704,
                "RESOLUTION_1536_512" => Resolution.x1536512,
                "RESOLUTION_1536_576" => Resolution.x1536576,
                "RESOLUTION_1536_640" => Resolution.x1536640,
                _ => null,
            };
        }
    }
}