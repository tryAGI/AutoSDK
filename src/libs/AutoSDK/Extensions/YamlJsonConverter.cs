using System.Globalization;
using System.Text.Json.Nodes;
using SharpYaml;
using SharpYaml.Events;

namespace AutoSDK.Extensions;

internal static class YamlJsonConverter
{
    public static JsonNode Parse(string yaml)
    {
        yaml = yaml ?? throw new ArgumentNullException(nameof(yaml));

        using var reader = new StringReader(yaml);
        var events = new EventReader(Parser.CreateParser(reader));
        events.Expect<StreamStart>();
        events.Expect<DocumentStart>();
        var result = ReadNode(events, new Dictionary<string, JsonNode?>(StringComparer.Ordinal));
        events.Expect<DocumentEnd>();
        events.Expect<StreamEnd>();
        return result ??
               throw new InvalidOperationException("The YAML document root cannot be null.");
    }

    private static JsonNode? ReadNode(
        EventReader events,
        IDictionary<string, JsonNode?> anchors)
    {
        if (events.Allow<AnchorAlias>() is { } alias)
        {
            if (!anchors.TryGetValue(alias.Value, out var anchored))
            {
                throw new InvalidOperationException($"Unknown YAML anchor '{alias.Value}'.");
            }

            return anchored?.DeepClone();
        }

        if (events.Allow<Scalar>() is { } scalar)
        {
            var result = ConvertValue(scalar.Value, scalar.Style);
            StoreAnchor(scalar.Anchor, result, anchors);
            return result;
        }

        if (events.Allow<MappingStart>() is { } mappingStart)
        {
            var result = new JsonObject();
            while (!events.Accept<MappingEnd>())
            {
                var key = events.Expect<Scalar>();
                result[key.Value] = ReadNode(events, anchors);
            }

            events.Expect<MappingEnd>();
            StoreAnchor(mappingStart.Anchor, result, anchors);
            return result;
        }

        if (events.Allow<SequenceStart>() is { } sequenceStart)
        {
            var result = new JsonArray();
            while (!events.Accept<SequenceEnd>())
            {
                result.Add(ReadNode(events, anchors));
            }

            events.Expect<SequenceEnd>();
            StoreAnchor(sequenceStart.Anchor, result, anchors);
            return result;
        }

        throw new InvalidOperationException("Expected a YAML scalar, mapping, sequence, or alias.");
    }

    private static void StoreAnchor(
        string? anchor,
        JsonNode? value,
        IDictionary<string, JsonNode?> anchors)
    {
        if (anchor is { Length: > 0 })
        {
            anchors[anchor] = value?.DeepClone();
        }
    }

    private static JsonValue? ConvertValue(string text, ScalarStyle style)
    {
        if (style != ScalarStyle.Plain)
        {
            return JsonValue.Create(text);
        }

        if (string.IsNullOrEmpty(text) ||
            string.Equals(text, "null", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(text, "~", StringComparison.Ordinal))
        {
            return null;
        }

        if (bool.TryParse(text, out var boolean))
        {
            return JsonValue.Create(boolean);
        }

        if (long.TryParse(text, NumberStyles.Integer, CultureInfo.InvariantCulture, out var integer))
        {
            return JsonValue.Create(integer);
        }

        if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var number))
        {
            return JsonValue.Create(number);
        }

        return JsonValue.Create(text);
    }
}
