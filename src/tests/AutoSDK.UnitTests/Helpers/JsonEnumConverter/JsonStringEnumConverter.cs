// using System;
// using System.Collections.Generic;
// using System.Globalization;
// using System.Linq;
// using System.Runtime.Serialization;
// using System.Text.Json;
// using System.Text.Json.Serialization;
//
// #nullable enable
//
// namespace AutoSDK.JsonConverters;
//
// /// <summary>
// /// https://github.com/dotnet/runtime/issues/74385#issuecomment-1456725149
// /// </summary>
// internal sealed class JsonStringEnumConverter<TEnum> : JsonConverter<TEnum> where TEnum : struct, Enum
// {
//     private readonly JsonNamingPolicy? _namingPolicy;
//     private readonly Dictionary<int, TEnum> _numberToEnum = new();
//     private readonly Dictionary<TEnum, string> _enumToString = new();
//     private readonly Dictionary<string, TEnum> _stringToEnum = new();
//
//     public JsonStringEnumConverter()
//     {
//         // We assume everything from OpenAI is snake case
//         _namingPolicy = new SnakeCaseNamingPolicy();
//         var type = typeof(TEnum);
//
//         foreach (var value in Enum.GetValues(typeof(TEnum)).Cast<TEnum>())
//         {
//             var enumMember = type.GetMember(value.ToString())[0];
//             var attribute = enumMember.GetCustomAttributes(typeof(EnumMemberAttribute), false)
//                 .Cast<EnumMemberAttribute>()
//                 .FirstOrDefault();
//             var index = Convert.ToInt32(type.GetField("value__")?.GetValue(value), CultureInfo.InvariantCulture);
//
//             if (attribute?.Value != null)
//             {
//                 _numberToEnum.Add(index, value);
//                 _enumToString.Add(value, attribute.Value);
//                 _stringToEnum.Add(attribute.Value, value);
//             }
//             else
//             {
//                 var convertedName = //_namingPolicy != null
//                     _namingPolicy.ConvertName(value.ToString());
//                     //: value.ToString();
//                 _numberToEnum.Add(index, value);
//                 _enumToString.Add(value, convertedName);
//                 _stringToEnum.Add(convertedName, value);
//             }
//         }
//     }
//
//     public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
//     {
//         var type = reader.TokenType;
//
//         switch (type)
//         {
//             case JsonTokenType.String:
//             {
//                 var stringValue = reader.GetString();
//
//                 if (stringValue != null)
//                 {
//                     var value = _namingPolicy != null
//                         ? _namingPolicy.ConvertName(stringValue)
//                         : stringValue;
//
//                     if (_stringToEnum.TryGetValue(value, out var enumValue))
//                     {
//                         return enumValue;
//                     }
//                 }
//
//                 break;
//             }
//             case JsonTokenType.Number:
//             {
//                 var numValue = reader.GetInt32();
//                 _numberToEnum.TryGetValue(numValue, out var enumValue);
//                 return enumValue;
//             }
//         }
//
//         return default;
//     }
//
//     public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
//         => writer.WriteStringValue(_enumToString[value]);
// }