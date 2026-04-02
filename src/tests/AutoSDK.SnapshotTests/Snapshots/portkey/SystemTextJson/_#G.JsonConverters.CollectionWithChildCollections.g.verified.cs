//HintName: G.JsonConverters.CollectionWithChildCollections.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CollectionWithChildCollectionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CollectionWithChildCollections>
    {
        /// <inheritdoc />
        public override global::G.CollectionWithChildCollections Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("is_default")) __score0++;
            if (__jsonProps.Contains("last_updated_at")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parent_collection_id")) __score0++;
            if (__jsonProps.Contains("slug")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("workspace_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("child_collections")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.Collection? collection = default;
            global::G.CollectionWithChildCollectionsVariant2? collectionWithChildCollectionsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        collection = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Collection>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        collectionWithChildCollectionsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CollectionWithChildCollectionsVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (collection == null && collectionWithChildCollectionsVariant2 == null)
            {
                try
                {
                    collection = global::System.Text.Json.JsonSerializer.Deserialize<global::G.Collection>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    collectionWithChildCollectionsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CollectionWithChildCollectionsVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CollectionWithChildCollections(
                collection,

                collectionWithChildCollectionsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CollectionWithChildCollections value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCollection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Collection, typeof(global::G.Collection), options);
            }
            else if (value.IsCollectionWithChildCollectionsVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CollectionWithChildCollectionsVariant2, typeof(global::G.CollectionWithChildCollectionsVariant2), options);
            }
        }
    }
}