//HintName: G.Models.DataTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        x_crossReference_,
        /// <summary>
        /// 
        /// </summary>
        Blob,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        DateArray,
        /// <summary>
        /// 
        /// </summary>
        GeoCoordinates,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        IntArray,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        NumberArray,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        ObjectArray,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        StringArray,
        /// <summary>
        /// 
        /// </summary>
        Uuid,
        /// <summary>
        /// 
        /// </summary>
        UuidArray,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataTypeItem value)
        {
            return value switch
            {
                DataTypeItem.x_crossReference_ => "<cross_reference>",
                DataTypeItem.Blob => "blob",
                DataTypeItem.Date => "date",
                DataTypeItem.DateArray => "date[]",
                DataTypeItem.GeoCoordinates => "geoCoordinates",
                DataTypeItem.Int => "int",
                DataTypeItem.IntArray => "int[]",
                DataTypeItem.Number => "number",
                DataTypeItem.NumberArray => "number[]",
                DataTypeItem.Object => "object",
                DataTypeItem.ObjectArray => "object[]",
                DataTypeItem.PhoneNumber => "phoneNumber",
                DataTypeItem.String => "string",
                DataTypeItem.StringArray => "string[]",
                DataTypeItem.Uuid => "uuid",
                DataTypeItem.UuidArray => "uuid[]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "<cross_reference>" => DataTypeItem.x_crossReference_,
                "blob" => DataTypeItem.Blob,
                "date" => DataTypeItem.Date,
                "date[]" => DataTypeItem.DateArray,
                "geoCoordinates" => DataTypeItem.GeoCoordinates,
                "int" => DataTypeItem.Int,
                "int[]" => DataTypeItem.IntArray,
                "number" => DataTypeItem.Number,
                "number[]" => DataTypeItem.NumberArray,
                "object" => DataTypeItem.Object,
                "object[]" => DataTypeItem.ObjectArray,
                "phoneNumber" => DataTypeItem.PhoneNumber,
                "string" => DataTypeItem.String,
                "string[]" => DataTypeItem.StringArray,
                "uuid" => DataTypeItem.Uuid,
                "uuid[]" => DataTypeItem.UuidArray,
                _ => null,
            };
        }
    }
}