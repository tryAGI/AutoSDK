//HintName: G.Models.DataTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DataTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string[]")]
        StringArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object")]
        Object,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object[]")]
        ObjectArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int")]
        Int,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int[]")]
        IntArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number[]")]
        NumberArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date")]
        Date,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date[]")]
        DateArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uuid")]
        Uuid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uuid[]")]
        UuidArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="geoCoordinates")]
        GeoCoordinates,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoneNumber")]
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blob")]
        Blob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<cross_reference>")]
        x_crossReference_,
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
                DataTypeItem.String => "string",
                DataTypeItem.StringArray => "string[]",
                DataTypeItem.Object => "object",
                DataTypeItem.ObjectArray => "object[]",
                DataTypeItem.Int => "int",
                DataTypeItem.IntArray => "int[]",
                DataTypeItem.Number => "number",
                DataTypeItem.NumberArray => "number[]",
                DataTypeItem.Date => "date",
                DataTypeItem.DateArray => "date[]",
                DataTypeItem.Uuid => "uuid",
                DataTypeItem.UuidArray => "uuid[]",
                DataTypeItem.GeoCoordinates => "geoCoordinates",
                DataTypeItem.PhoneNumber => "phoneNumber",
                DataTypeItem.Blob => "blob",
                DataTypeItem.x_crossReference_ => "<cross_reference>",
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
                "string" => DataTypeItem.String,
                "string[]" => DataTypeItem.StringArray,
                "object" => DataTypeItem.Object,
                "object[]" => DataTypeItem.ObjectArray,
                "int" => DataTypeItem.Int,
                "int[]" => DataTypeItem.IntArray,
                "number" => DataTypeItem.Number,
                "number[]" => DataTypeItem.NumberArray,
                "date" => DataTypeItem.Date,
                "date[]" => DataTypeItem.DateArray,
                "uuid" => DataTypeItem.Uuid,
                "uuid[]" => DataTypeItem.UuidArray,
                "geoCoordinates" => DataTypeItem.GeoCoordinates,
                "phoneNumber" => DataTypeItem.PhoneNumber,
                "blob" => DataTypeItem.Blob,
                "<cross_reference>" => DataTypeItem.x_crossReference_,
                _ => null,
            };
        }
    }
}