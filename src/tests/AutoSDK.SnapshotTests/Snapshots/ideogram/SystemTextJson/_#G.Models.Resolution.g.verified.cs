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
        RESOLUTION5121536,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION5761408,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION5761472,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION5761536,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION6401024,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION6401344,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION6401408,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION6401472,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION6401536,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7041152,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7041216,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7041280,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7041344,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7041408,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7041472,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7201280,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7361312,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7681024,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7681088,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7681152,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7681216,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7681232,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7681280,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION7681344,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION832960,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8321024,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8321088,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8321152,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8321216,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8321248,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8641152,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION896960,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8961024,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8961088,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8961120,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION8961152,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION960832,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION960896,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION9601024,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION9601088,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1024640,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1024768,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1024832,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1024896,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1024960,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION10241024,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1088768,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1088832,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1088896,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1088960,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1120896,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1152704,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1152768,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1152832,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1152864,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1152896,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1216704,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1216768,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1216832,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1232768,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1248832,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1280704,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1280720,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1280768,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1280800,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1312736,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1344640,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1344704,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1344768,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1408576,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1408640,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1408704,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1472576,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1472640,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1472704,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1536512,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1536576,
        /// <summary>
        /// 
        /// </summary>
        RESOLUTION1536640,
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
                Resolution.RESOLUTION5121536 => "RESOLUTION_512_1536",
                Resolution.RESOLUTION5761408 => "RESOLUTION_576_1408",
                Resolution.RESOLUTION5761472 => "RESOLUTION_576_1472",
                Resolution.RESOLUTION5761536 => "RESOLUTION_576_1536",
                Resolution.RESOLUTION6401024 => "RESOLUTION_640_1024",
                Resolution.RESOLUTION6401344 => "RESOLUTION_640_1344",
                Resolution.RESOLUTION6401408 => "RESOLUTION_640_1408",
                Resolution.RESOLUTION6401472 => "RESOLUTION_640_1472",
                Resolution.RESOLUTION6401536 => "RESOLUTION_640_1536",
                Resolution.RESOLUTION7041152 => "RESOLUTION_704_1152",
                Resolution.RESOLUTION7041216 => "RESOLUTION_704_1216",
                Resolution.RESOLUTION7041280 => "RESOLUTION_704_1280",
                Resolution.RESOLUTION7041344 => "RESOLUTION_704_1344",
                Resolution.RESOLUTION7041408 => "RESOLUTION_704_1408",
                Resolution.RESOLUTION7041472 => "RESOLUTION_704_1472",
                Resolution.RESOLUTION7201280 => "RESOLUTION_720_1280",
                Resolution.RESOLUTION7361312 => "RESOLUTION_736_1312",
                Resolution.RESOLUTION7681024 => "RESOLUTION_768_1024",
                Resolution.RESOLUTION7681088 => "RESOLUTION_768_1088",
                Resolution.RESOLUTION7681152 => "RESOLUTION_768_1152",
                Resolution.RESOLUTION7681216 => "RESOLUTION_768_1216",
                Resolution.RESOLUTION7681232 => "RESOLUTION_768_1232",
                Resolution.RESOLUTION7681280 => "RESOLUTION_768_1280",
                Resolution.RESOLUTION7681344 => "RESOLUTION_768_1344",
                Resolution.RESOLUTION832960 => "RESOLUTION_832_960",
                Resolution.RESOLUTION8321024 => "RESOLUTION_832_1024",
                Resolution.RESOLUTION8321088 => "RESOLUTION_832_1088",
                Resolution.RESOLUTION8321152 => "RESOLUTION_832_1152",
                Resolution.RESOLUTION8321216 => "RESOLUTION_832_1216",
                Resolution.RESOLUTION8321248 => "RESOLUTION_832_1248",
                Resolution.RESOLUTION8641152 => "RESOLUTION_864_1152",
                Resolution.RESOLUTION896960 => "RESOLUTION_896_960",
                Resolution.RESOLUTION8961024 => "RESOLUTION_896_1024",
                Resolution.RESOLUTION8961088 => "RESOLUTION_896_1088",
                Resolution.RESOLUTION8961120 => "RESOLUTION_896_1120",
                Resolution.RESOLUTION8961152 => "RESOLUTION_896_1152",
                Resolution.RESOLUTION960832 => "RESOLUTION_960_832",
                Resolution.RESOLUTION960896 => "RESOLUTION_960_896",
                Resolution.RESOLUTION9601024 => "RESOLUTION_960_1024",
                Resolution.RESOLUTION9601088 => "RESOLUTION_960_1088",
                Resolution.RESOLUTION1024640 => "RESOLUTION_1024_640",
                Resolution.RESOLUTION1024768 => "RESOLUTION_1024_768",
                Resolution.RESOLUTION1024832 => "RESOLUTION_1024_832",
                Resolution.RESOLUTION1024896 => "RESOLUTION_1024_896",
                Resolution.RESOLUTION1024960 => "RESOLUTION_1024_960",
                Resolution.RESOLUTION10241024 => "RESOLUTION_1024_1024",
                Resolution.RESOLUTION1088768 => "RESOLUTION_1088_768",
                Resolution.RESOLUTION1088832 => "RESOLUTION_1088_832",
                Resolution.RESOLUTION1088896 => "RESOLUTION_1088_896",
                Resolution.RESOLUTION1088960 => "RESOLUTION_1088_960",
                Resolution.RESOLUTION1120896 => "RESOLUTION_1120_896",
                Resolution.RESOLUTION1152704 => "RESOLUTION_1152_704",
                Resolution.RESOLUTION1152768 => "RESOLUTION_1152_768",
                Resolution.RESOLUTION1152832 => "RESOLUTION_1152_832",
                Resolution.RESOLUTION1152864 => "RESOLUTION_1152_864",
                Resolution.RESOLUTION1152896 => "RESOLUTION_1152_896",
                Resolution.RESOLUTION1216704 => "RESOLUTION_1216_704",
                Resolution.RESOLUTION1216768 => "RESOLUTION_1216_768",
                Resolution.RESOLUTION1216832 => "RESOLUTION_1216_832",
                Resolution.RESOLUTION1232768 => "RESOLUTION_1232_768",
                Resolution.RESOLUTION1248832 => "RESOLUTION_1248_832",
                Resolution.RESOLUTION1280704 => "RESOLUTION_1280_704",
                Resolution.RESOLUTION1280720 => "RESOLUTION_1280_720",
                Resolution.RESOLUTION1280768 => "RESOLUTION_1280_768",
                Resolution.RESOLUTION1280800 => "RESOLUTION_1280_800",
                Resolution.RESOLUTION1312736 => "RESOLUTION_1312_736",
                Resolution.RESOLUTION1344640 => "RESOLUTION_1344_640",
                Resolution.RESOLUTION1344704 => "RESOLUTION_1344_704",
                Resolution.RESOLUTION1344768 => "RESOLUTION_1344_768",
                Resolution.RESOLUTION1408576 => "RESOLUTION_1408_576",
                Resolution.RESOLUTION1408640 => "RESOLUTION_1408_640",
                Resolution.RESOLUTION1408704 => "RESOLUTION_1408_704",
                Resolution.RESOLUTION1472576 => "RESOLUTION_1472_576",
                Resolution.RESOLUTION1472640 => "RESOLUTION_1472_640",
                Resolution.RESOLUTION1472704 => "RESOLUTION_1472_704",
                Resolution.RESOLUTION1536512 => "RESOLUTION_1536_512",
                Resolution.RESOLUTION1536576 => "RESOLUTION_1536_576",
                Resolution.RESOLUTION1536640 => "RESOLUTION_1536_640",
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
                "RESOLUTION_512_1536" => Resolution.RESOLUTION5121536,
                "RESOLUTION_576_1408" => Resolution.RESOLUTION5761408,
                "RESOLUTION_576_1472" => Resolution.RESOLUTION5761472,
                "RESOLUTION_576_1536" => Resolution.RESOLUTION5761536,
                "RESOLUTION_640_1024" => Resolution.RESOLUTION6401024,
                "RESOLUTION_640_1344" => Resolution.RESOLUTION6401344,
                "RESOLUTION_640_1408" => Resolution.RESOLUTION6401408,
                "RESOLUTION_640_1472" => Resolution.RESOLUTION6401472,
                "RESOLUTION_640_1536" => Resolution.RESOLUTION6401536,
                "RESOLUTION_704_1152" => Resolution.RESOLUTION7041152,
                "RESOLUTION_704_1216" => Resolution.RESOLUTION7041216,
                "RESOLUTION_704_1280" => Resolution.RESOLUTION7041280,
                "RESOLUTION_704_1344" => Resolution.RESOLUTION7041344,
                "RESOLUTION_704_1408" => Resolution.RESOLUTION7041408,
                "RESOLUTION_704_1472" => Resolution.RESOLUTION7041472,
                "RESOLUTION_720_1280" => Resolution.RESOLUTION7201280,
                "RESOLUTION_736_1312" => Resolution.RESOLUTION7361312,
                "RESOLUTION_768_1024" => Resolution.RESOLUTION7681024,
                "RESOLUTION_768_1088" => Resolution.RESOLUTION7681088,
                "RESOLUTION_768_1152" => Resolution.RESOLUTION7681152,
                "RESOLUTION_768_1216" => Resolution.RESOLUTION7681216,
                "RESOLUTION_768_1232" => Resolution.RESOLUTION7681232,
                "RESOLUTION_768_1280" => Resolution.RESOLUTION7681280,
                "RESOLUTION_768_1344" => Resolution.RESOLUTION7681344,
                "RESOLUTION_832_960" => Resolution.RESOLUTION832960,
                "RESOLUTION_832_1024" => Resolution.RESOLUTION8321024,
                "RESOLUTION_832_1088" => Resolution.RESOLUTION8321088,
                "RESOLUTION_832_1152" => Resolution.RESOLUTION8321152,
                "RESOLUTION_832_1216" => Resolution.RESOLUTION8321216,
                "RESOLUTION_832_1248" => Resolution.RESOLUTION8321248,
                "RESOLUTION_864_1152" => Resolution.RESOLUTION8641152,
                "RESOLUTION_896_960" => Resolution.RESOLUTION896960,
                "RESOLUTION_896_1024" => Resolution.RESOLUTION8961024,
                "RESOLUTION_896_1088" => Resolution.RESOLUTION8961088,
                "RESOLUTION_896_1120" => Resolution.RESOLUTION8961120,
                "RESOLUTION_896_1152" => Resolution.RESOLUTION8961152,
                "RESOLUTION_960_832" => Resolution.RESOLUTION960832,
                "RESOLUTION_960_896" => Resolution.RESOLUTION960896,
                "RESOLUTION_960_1024" => Resolution.RESOLUTION9601024,
                "RESOLUTION_960_1088" => Resolution.RESOLUTION9601088,
                "RESOLUTION_1024_640" => Resolution.RESOLUTION1024640,
                "RESOLUTION_1024_768" => Resolution.RESOLUTION1024768,
                "RESOLUTION_1024_832" => Resolution.RESOLUTION1024832,
                "RESOLUTION_1024_896" => Resolution.RESOLUTION1024896,
                "RESOLUTION_1024_960" => Resolution.RESOLUTION1024960,
                "RESOLUTION_1024_1024" => Resolution.RESOLUTION10241024,
                "RESOLUTION_1088_768" => Resolution.RESOLUTION1088768,
                "RESOLUTION_1088_832" => Resolution.RESOLUTION1088832,
                "RESOLUTION_1088_896" => Resolution.RESOLUTION1088896,
                "RESOLUTION_1088_960" => Resolution.RESOLUTION1088960,
                "RESOLUTION_1120_896" => Resolution.RESOLUTION1120896,
                "RESOLUTION_1152_704" => Resolution.RESOLUTION1152704,
                "RESOLUTION_1152_768" => Resolution.RESOLUTION1152768,
                "RESOLUTION_1152_832" => Resolution.RESOLUTION1152832,
                "RESOLUTION_1152_864" => Resolution.RESOLUTION1152864,
                "RESOLUTION_1152_896" => Resolution.RESOLUTION1152896,
                "RESOLUTION_1216_704" => Resolution.RESOLUTION1216704,
                "RESOLUTION_1216_768" => Resolution.RESOLUTION1216768,
                "RESOLUTION_1216_832" => Resolution.RESOLUTION1216832,
                "RESOLUTION_1232_768" => Resolution.RESOLUTION1232768,
                "RESOLUTION_1248_832" => Resolution.RESOLUTION1248832,
                "RESOLUTION_1280_704" => Resolution.RESOLUTION1280704,
                "RESOLUTION_1280_720" => Resolution.RESOLUTION1280720,
                "RESOLUTION_1280_768" => Resolution.RESOLUTION1280768,
                "RESOLUTION_1280_800" => Resolution.RESOLUTION1280800,
                "RESOLUTION_1312_736" => Resolution.RESOLUTION1312736,
                "RESOLUTION_1344_640" => Resolution.RESOLUTION1344640,
                "RESOLUTION_1344_704" => Resolution.RESOLUTION1344704,
                "RESOLUTION_1344_768" => Resolution.RESOLUTION1344768,
                "RESOLUTION_1408_576" => Resolution.RESOLUTION1408576,
                "RESOLUTION_1408_640" => Resolution.RESOLUTION1408640,
                "RESOLUTION_1408_704" => Resolution.RESOLUTION1408704,
                "RESOLUTION_1472_576" => Resolution.RESOLUTION1472576,
                "RESOLUTION_1472_640" => Resolution.RESOLUTION1472640,
                "RESOLUTION_1472_704" => Resolution.RESOLUTION1472704,
                "RESOLUTION_1536_512" => Resolution.RESOLUTION1536512,
                "RESOLUTION_1536_576" => Resolution.RESOLUTION1536576,
                "RESOLUTION_1536_640" => Resolution.RESOLUTION1536640,
                _ => null,
            };
        }
    }
}