//HintName: G.JsonConverters.Expr.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ExprJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Expr>
    {
        /// <inheritdoc />
        public override global::G.Expr Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("$ref_new")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::G.ExprRefNew? refNew = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExprRefNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExprRefNew> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExprRefNew).Name}");
                        refNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (refNew == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExprRefNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExprRefNew> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExprRefNew).Name}");
                    refNew = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Expr(
                refNew
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Expr value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRefNew)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ExprRefNew), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ExprRefNew?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ExprRefNew).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RefNew, typeInfo);
            }
        }
    }
}