using AutoSDK.Models;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateEnumJsonConverter(
        ModelData model,
        CancellationToken cancellationToken = default)
    {
        if (model.Settings.UsesNewtonsoftJson())
        {
            return model.IsOpenEnum
                ? $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}JsonConverter : global::Newtonsoft.Json.JsonConverter<{model.GlobalClassName}>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName} ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            {model.GlobalClassName} existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {{
                return existingValue;
            }}

            switch (reader.TokenType)
            {{
                case global::Newtonsoft.Json.JsonToken.String:
                {{
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue) ?? default;
                    }}

                    break;
                }}
                case global::Newtonsoft.Json.JsonToken.Null:
                {{
                    return default({model.GlobalClassName});
                }}
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            {model.GlobalClassName} value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue({model.GlobalClassName}Extensions.ToValueString(value));
        }}
    }}
}}
"
                : $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}JsonConverter : global::Newtonsoft.Json.JsonConverter<{model.GlobalClassName}>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName} ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            {model.GlobalClassName} existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {{
                return existingValue;
            }}

            switch (reader.TokenType)
            {{
                case global::Newtonsoft.Json.JsonToken.String:
                {{
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue) ?? default;
                    }}

                    break;
                }}
                case global::Newtonsoft.Json.JsonToken.Integer:
                {{
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {{
                        return ({model.GlobalClassName})numValue.Value;
                    }}

                    break;
                }}
                case global::Newtonsoft.Json.JsonToken.Null:
                {{
                    return default({model.GlobalClassName});
                }}
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            {model.GlobalClassName} value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue({model.GlobalClassName}Extensions.ToValueString(value));
        }}
    }}
}}
";
        }

        return model.IsOpenEnum
            ? $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}JsonConverter : global::System.Text.Json.Serialization.JsonConverter<{model.GlobalClassName}>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName} Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            switch (reader.TokenType)
            {{
                case global::System.Text.Json.JsonTokenType.String:
                {{
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue) ?? default;
                    }}

                    break;
                }}
                case global::System.Text.Json.JsonTokenType.Null:
                {{
                    return default({model.GlobalClassName});
                }}
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {model.GlobalClassName} value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue({model.GlobalClassName}Extensions.ToValueString(value));
        }}
    }}
}}
"
            : $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}JsonConverter : global::System.Text.Json.Serialization.JsonConverter<{model.GlobalClassName}>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName} Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            switch (reader.TokenType)
            {{
                case global::System.Text.Json.JsonTokenType.String:
                {{
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue) ?? default;
                    }}
                    
                    break;
                }}
                case global::System.Text.Json.JsonTokenType.Number:
                {{
                    var numValue = reader.GetInt32();
                    return ({model.GlobalClassName})numValue;
                }}
                case global::System.Text.Json.JsonTokenType.Null:
                {{
                    return default({model.GlobalClassName});
                }}
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {model.GlobalClassName} value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue({model.GlobalClassName}Extensions.ToValueString(value));
        }}
    }}
}}
";
    }
    
    public static string GenerateEnumNullableJsonConverter(
        ModelData model,
        CancellationToken cancellationToken = default)
    {
        if (model.Settings.UsesNewtonsoftJson())
        {
            return model.IsOpenEnum
                ? $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<{model.GlobalClassName}?>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName}? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            {model.GlobalClassName}? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {{
                return existingValue;
            }}

            switch (reader.TokenType)
            {{
                case global::Newtonsoft.Json.JsonToken.String:
                {{
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue);
                    }}

                    break;
                }}
                case global::Newtonsoft.Json.JsonToken.Null:
                {{
                    return default({model.GlobalClassName}?);
                }}
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            {model.GlobalClassName}? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {{
                writer.WriteNull();
            }}
            else
            {{
                writer.WriteValue({model.GlobalClassName}Extensions.ToValueString(value.Value));
            }}
        }}
    }}
}}
"
                : $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<{model.GlobalClassName}?>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName}? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            {model.GlobalClassName}? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {{
                return existingValue;
            }}

            switch (reader.TokenType)
            {{
                case global::Newtonsoft.Json.JsonToken.String:
                {{
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue);
                    }}

                    break;
                }}
                case global::Newtonsoft.Json.JsonToken.Integer:
                {{
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {{
                        return ({model.GlobalClassName})numValue.Value;
                    }}

                    break;
                }}
                case global::Newtonsoft.Json.JsonToken.Null:
                {{
                    return default({model.GlobalClassName}?);
                }}
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            {model.GlobalClassName}? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {{
                writer.WriteNull();
            }}
            else
            {{
                writer.WriteValue({model.GlobalClassName}Extensions.ToValueString(value.Value));
            }}
        }}
    }}
}}
";
        }

        return model.IsOpenEnum
            ? $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<{model.GlobalClassName}?>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName}? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            switch (reader.TokenType)
            {{
                case global::System.Text.Json.JsonTokenType.String:
                {{
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue);
                    }}

                    break;
                }}
                case global::System.Text.Json.JsonTokenType.Null:
                {{
                    return default({model.GlobalClassName}?);
                }}
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {model.GlobalClassName}? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {{
                writer.WriteNullValue();
            }}
            else
            {{
                writer.WriteStringValue({model.GlobalClassName}Extensions.ToValueString(value.Value));
            }}
        }}
    }}
}}
"
            : $@"#nullable enable

namespace {model.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {model.ClassName}NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<{model.GlobalClassName}?>
    {{
        /// <inheritdoc />
        public override {model.GlobalClassName}? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            switch (reader.TokenType)
            {{
                case global::System.Text.Json.JsonTokenType.String:
                {{
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {{
                        return {model.GlobalClassName}Extensions.ToEnum(stringValue);
                    }}
                    
                    break;
                }}
                case global::System.Text.Json.JsonTokenType.Number:
                {{
                    var numValue = reader.GetInt32();
                    return ({model.GlobalClassName})numValue;
                }}
                case global::System.Text.Json.JsonTokenType.Null:
                {{
                    return default({model.GlobalClassName}?);
                }}
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {model.GlobalClassName}? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {{
                writer.WriteNullValue();
            }}
            else
            {{
                writer.WriteStringValue({model.GlobalClassName}Extensions.ToValueString(value.Value));
            }}
        }}
    }}
}}
";
    }
}
