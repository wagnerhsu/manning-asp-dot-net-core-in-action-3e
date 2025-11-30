# Upgrades <TargetFramework> or <TargetFrameworks> entries to net10.0
# Usage: run from repo root or the MyCode folder with PowerShell

$root = Get-Location
Write-Host "Scanning for .csproj files under $root"
$files = Get-ChildItem -Path $root -Recurse -Filter *.csproj -ErrorAction SilentlyContinue

if (-not $files) {
    Write-Host "No .csproj files found."
    exit 0
}

$regex = '<TargetFrameworks?\s*>[^<]*</TargetFrameworks?>'
$replacement = '<TargetFramework>net10.0</TargetFramework>'

foreach ($f in $files) {
    $path = $f.FullName
    $content = Get-Content -Path $path -Raw -ErrorAction Stop
    $new = [Regex]::Replace($content, $regex, $replacement, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)
    if ($new -ne $content) {
        Set-Content -Path $path -Value $new -Encoding UTF8
        Write-Host "Updated: $path"
    }
}

Write-Host "Done. Consider running 'dotnet build' on projects to verify."