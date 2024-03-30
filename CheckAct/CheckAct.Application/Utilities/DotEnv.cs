using System;
using System.IO;

namespace CheckAct.Application.Utilities;

/// <summary>
/// Предоставляет методы для работы с файлами .env и установки переменных окружения.
/// </summary>
public static class DotEnv
{
    /// <summary>
    /// Загружает переменные окружения из файла .env.
    /// </summary>
    /// <param name="filePath">Путь к файлу .env.</param>
    public static void Load(string filePath)
    {
        if (!File.Exists(filePath))
            return;

        foreach (var line in File.ReadAllLines(filePath))
        {
            var index = line.IndexOf('=');
            if (index == -1)
                continue;

            var key = line[..index].Trim();
            var value = line[(index + 1)..].Trim();

            Environment.SetEnvironmentVariable(key, value);
        }
    }
}