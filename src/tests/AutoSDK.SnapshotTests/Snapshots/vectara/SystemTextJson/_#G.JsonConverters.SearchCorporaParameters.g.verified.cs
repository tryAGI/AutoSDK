//HintName: G.JsonConverters.SearchCorporaParameters.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SearchCorporaParametersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SearchCorporaParameters>
    {
        /// <inheritdoc />
        public override global::G.SearchCorporaParameters Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::G.SearchCorporaParametersVariant1? searchCorporaParametersVariant1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchCorporaParametersVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchCorporaParametersVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SearchCorporaParametersVariant1).Name}");
                searchCorporaParametersVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::G.SearchParameters? searchParameters = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchParameters> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SearchParameters).Name}");
                searchParameters = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::G.SearchCorporaParameters(
                searchCorporaParametersVariant1,

                searchParameters
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SearchCorporaParameters value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsSearchCorporaParametersVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchCorporaParametersVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchCorporaParametersVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SearchCorporaParametersVariant1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SearchCorporaParametersVariant1!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsSearchParameters)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchParameters), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchParameters?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SearchParameters).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SearchParameters!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}