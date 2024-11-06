using System.Text.RegularExpressions;
using SharpYaml.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace AutoSDK.Helpers;

public static class OpenApi31Support
{
    public static bool IsOpenApi31(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        
        return input.Contains("openapi: 3.1.0") ||
               input.Contains("\"openapi\":\"3.1.0\"") ||
               input.Contains("\"openapi\": \"3.1.0\"");
    }
    
    public static string ConvertToOpenApi30(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        
        if (input.StartsWith("{", StringComparison.Ordinal))
        {
            return ConvertJsonToOpenApi30(input);
        }

        return ConvertYamlToOpenApi30(input);
    }
    
    public static string ConvertJsonToOpenApi30(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));

        if (JsonNode.Parse(input) is not JsonObject jsonNode)
        {
            return input;
        }

        ConvertJsonNode(jsonNode);

        var output = jsonNode.ToJsonString(new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return output;
    }
    
    private static void ConvertJsonNode(JsonObject node)
    {
        node = node ?? throw new ArgumentNullException(nameof(node));

        foreach (var entry in node.ToList())
        {
            // Recursively convert child nodes if the value is an object
            if (entry.Value is JsonObject childNode)
            {
                ConvertJsonNode(childNode);
            }
            else if (entry.Value is JsonArray listNode)
            {
                // Recursively convert each item in a sequence (array)
                foreach (var item in listNode)
                {
                    if (item is JsonObject listItem)
                    {
                        ConvertJsonNode(listItem);
                    }
                }
            }

            string keyString = entry.Key;
            if (keyString == "openapi")
            {
                node["openapi"] = "3.0.3";
            }

            if (keyString is "anyOf" or "oneOf" or "allOf" &&
                entry.Value is JsonArray { Count: 2 } anyOfList &&
                anyOfList.Any(v =>
                    v is JsonObject objects &&
                    objects.ContainsKey("type") &&
                    objects["type"]?.ToJsonString() == "\"null\""))
            {
                var first = anyOfList[0] as JsonObject;
                var second = anyOfList[1] as JsonObject;
                var firstType = first?["type"];
                var secondType = second?["type"];
            
                // Replace "anyOf" with "type: string, nullable: true"
                node["type"] =  firstType?.ToJsonString() == "\"null\""
                    ? secondType?.DeepClone()
                    : firstType?.DeepClone();
                node["nullable"] = true;
        
                var nonNullObject = firstType?.ToJsonString() == "\"null\""
                    ? second
                    : first;
                foreach (var kvp in nonNullObject!)
                {
                    node[kvp.Key] = kvp.Value?.DeepClone();
                }
                
                node.Remove(keyString);
            }
            
            if (keyString is "anyOf" or "oneOf" or "allOf" &&
                entry.Value is JsonArray { Count: > 2 } anyOfList3 &&
                anyOfList3.Any(v =>
                    v is JsonObject objects &&
                    objects.ContainsKey("type") &&
                    objects["type"]?.ToJsonString() == "\"null\""))
            {
                node[keyString] = new JsonArray(anyOfList3
                    .Where(v =>
                        v is JsonObject objects &&
                        (!objects.ContainsKey("type") ||
                        objects["type"]?.ToJsonString() != "\"null\""))
                    .Select(v => v?.DeepClone())
                    .ToArray());
                node["nullable"] = true;
            }
            
            if (keyString == "exclusiveMinimum")
            {
                node["minimum"] = entry.Value?.DeepClone();
                node["exclusiveMinimum"] = true;
            }
            if (keyString == "exclusiveMaximum")
            {
                node["maximum"] = entry.Value?.DeepClone();
                node["exclusiveMaximum"] = true;
            }
            
            // Identify "type" that is a list containing "string" and "null"
            if (keyString == "type" &&
                entry.Value is JsonArray typeList &&
                typeList.Contains(null))
            {
                // Replace "type" with "string" and add "nullable: true"
                node["type"] = typeList.First(v => v != null)?.ToString();
                node["nullable"] = true;
            
                // If there's an "enum", remove the "null" from its values
                if (node.TryGetPropertyValue("enum", out var enumValue) && enumValue is JsonArray enumList)
                {
                    node["enum"] = new JsonArray(enumList.Where(v => v != null).ToArray());
                }
            }
            
            if (keyString == "ge")
            {
                node.Remove(keyString);
                node["minimum"] = entry.Value?.DeepClone();
            }
            if (keyString == "le")
            {
                node.Remove(keyString);
                node["maximum"] = entry.Value?.DeepClone();
            }
            
            // Remove "prefixItems"
            if (keyString == "prefixItems" && entry.Value is JsonArray { Count: > 0 } prefixItemsList)
            {
                node.Remove(keyString);
                if (!node.ContainsKey("items"))
                {
                    node["items"] = prefixItemsList[0]?.DeepClone();
                }
            }
            
            // Replace "examples" with single "example"
            if (keyString == "examples" && entry.Value is JsonArray { Count: > 0 } examplesList)
            {
                node.Remove(keyString);
                node["example"] = examplesList[0]?.DeepClone();
            }
            
            // Fix "example" node when "items" is missing and "example" is a list
            if (keyString == "example" && entry.Value is JsonArray { Count: > 0 } exampleList && !node.ContainsKey("items"))
            {
                node["example"] = exampleList[0]?.DeepClone();
            }
            
            // Identify "const" node for removal and convert to "enum" if "enum" is missing
            if (keyString == "const")
            {
                if (!node.ContainsKey("enum"))
                {
                    node["enum"] = new JsonArray(entry.Value);
                }
                node.Remove(keyString);
            }
            
            // Fix "items" node when "$ref" is present and "items" is a list
            if (keyString == "items" && entry.Value is JsonArray itemsNode &&
                itemsNode.ElementAtOrDefault(0) is JsonObject itemsValue &&
                itemsValue.ElementAtOrDefault(0).Key == "$ref")
            {
                node["items"] = itemsValue.DeepClone();
            }
        }
    }
    
    public static string ConvertYamlToOpenApi30(string input)
    {
        input = input ?? throw new ArgumentNullException(nameof(input));
        
        var serializer = new Serializer(new SerializerSettings
        {
            EmitTags = false, // Avoid emitting tags
            EmitDefaultValues = true, // Ensure all values are serialized
            IgnoreUnmatchedProperties = true // Ignore properties that do not match the class
        });
        if (serializer.Deserialize<object>(new StringReader(input)) is not Dictionary<object, object?> yamlObject)
        {
            return input;
        }
        
        ConvertYamlNode(yamlObject);
        
        return serializer.Serialize(yamlObject);
    }
    
    private static void ConvertYamlNode(Dictionary<object, object?> node)
    {
        node = node ?? throw new ArgumentNullException(nameof(node));

        foreach (var entry in new Dictionary<object, object?>(node))
        {
            // Recursively convert child nodes if the value is a dictionary
            if (entry.Value is Dictionary<object, object?> childNode)
            {
                ConvertYamlNode(childNode);
            }
            else if (entry.Value is List<object> listNode)
            {
                // Recursively convert each item in a sequence (list)
                foreach (var item in listNode)
                {
                    if (item is Dictionary<object, object?> listItem)
                    {
                        ConvertYamlNode(listItem);
                    }
                }
            }
            
            var keyString = entry.Key as string;
            if (keyString is "anyOf" or "oneOf" or "allOf" &&
                entry.Value is List<object?> anyOfList && anyOfList.Count == 2 &&
                anyOfList.Any(v =>
                    v is Dictionary<object, object?> objects &&
                    objects.ContainsKey("type") &&
                    objects["type"] is null))
            {
                var first = anyOfList[0] as Dictionary<object, object?>;
                var second = anyOfList[1] as Dictionary<object, object?>;
                var firstType = first?.TryGetValue("type", out var firstResult) == true ? firstResult : null;
                var secondType = second?.TryGetValue("type", out var secondResult) == true ? secondResult : null;
                if (secondType == null || 
                    firstType == null)
                {
                    // Replace "anyOf" with "type: string, nullable: true"
                    node[new string("type".ToCharArray())] = firstType ?? secondType;
                    node[new string("nullable".ToCharArray())] = true;
                    if (firstType != null)
                    {
                        foreach (var key in first ?? new Dictionary<object, object?>())
                        {
                            node[key.Key] = key.Value;
                        }
                    }
                    else
                    {
                        foreach (var key in second ?? new Dictionary<object, object?>())
                        {
                            node[key.Key] = key.Value;
                        }
                    }
                    node.Remove(keyString);
                }
            }
            if (keyString == "openapi")
            {
                node[new string("openapi".ToCharArray())] = "3.0.3";
            }
            if (keyString == "exclusiveMinimum" &&
                entry.Value is not bool)
            {
                node[new string("minimum".ToCharArray())] = entry.Value;
                node[new string("exclusiveMinimum".ToCharArray())] = true;
            }
            if (keyString == "exclusiveMaximum" &&
                entry.Value is not bool)
            {
                node[new string("maximum".ToCharArray())] = entry.Value;
                node[new string("exclusiveMaximum".ToCharArray())] = true;
            }
            
            if (keyString == "allOf" &&
                entry.Value is List<object?> { Count: 2 } allOfItems &&
                allOfItems.Any(v =>
                    v is Dictionary<object, object?> objects &&
                    objects.ContainsKey("nullable") &&
                    objects["nullable"] is true))
            {
                var first = allOfItems[0] as Dictionary<object, object?>;
                var second = allOfItems[1] as Dictionary<object, object?>;
                
                if (first?.ContainsKey("nullable") != true)
                {
                    foreach (var key in first ?? new Dictionary<object, object?>())
                    {
                        node[key.Key] = key.Value;
                    }
                }
                else
                {
                    foreach (var key in second ?? new Dictionary<object, object?>())
                    {
                        node[key.Key] = key.Value;
                    }
                }

                node.Remove(keyString);
            }
            
            if (keyString == "enum" &&
                entry.Value is List<object?> { Count: > 0 } enumItems &&
                enumItems.Contains(null))
            {
                node[new string("enum".ToCharArray())] = enumItems.Where(v => v != null).ToList();
                node[new string("nullable".ToCharArray())] = true;
            }
            
            // Remove "prefixItems"
            if (keyString == "prefixItems" && entry.Value is List<object?> { Count: > 0 } prefixItemsList)
            {
                node.Remove(keyString);
                if (!node.ContainsKey("items"))
                {
                    node[new string("items".ToCharArray())] = prefixItemsList[0];
                }
            }

            // Identify "type" that is a list containing "string" and "null"
            if (keyString == "type" &&
                entry.Value is List<object?> typeList &&
                typeList.Contains(null))
            {
                // Replace "type" with "string" and add "nullable: true"
                node[new string("type".ToCharArray())] = typeList.First(v => v != null);
                node[new string("nullable".ToCharArray())] = true;
                
                // If there's an "enum", remove the "null" from its values
                if (node.TryGetValue("enum", out var enumValue) && enumValue is List<object?> enumList)
                {
                    node[new string("enum".ToCharArray())] = enumList.Where(v => v != null).ToList();
                }
            }
            
            // Replace "examples" with single "example"
            if (keyString == "examples" &&
                entry.Value is List<object> { Count: > 0 } examplesList)
            {
                node.Remove(keyString);

                node[new string("example".ToCharArray())] = examplesList.First();
            }
            
            // Fix "example" node when "items" is missing and "example" is a list
            if (keyString == "example" &&
                entry.Value is List<object> { Count: > 0 } exampleList &&
                !node.ContainsKey("items"))
            {
                node[new string("example".ToCharArray())] = exampleList.First();
            }
            
            // Identify "const" node for removal and convert to "enum" if "enum" is missing
            if (keyString == "const")
            {
                if (!node.ContainsKey("enum"))
                {
                    node[new string("enum".ToCharArray())] = new List<object?>
                    {
                        entry.Value,
                    };
                }
                node.Remove(keyString);
            }
            
            // Fix "items" node when "$ref" is present and "items" is a list
            if (keyString == "items" &&
                entry.Value is List<object?> itemsNode &&
                itemsNode.ElementAtOrDefault(0) is Dictionary<object, object?> itemsValue &&
                itemsValue.ElementAtOrDefault(0).Key is "$ref")
            {
                node[new string("items".ToCharArray())] = itemsValue;
            }
        }
    }
}