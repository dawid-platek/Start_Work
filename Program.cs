using System;
using System.Diagnostics;

namespace OpenWebsitesAndDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Otwieranie strony internetowej
            //string url = "https://www.twojastrona.pl";
            // Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

            // Ścieżka do przeglądarki Google Chrome
            // string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            // Process.Start(new ProcessStartInfo(chromePath, url) { UseShellExecute = true });

            // Otwieranie dysku E
            //string drivePath = "E:\\";
            // Process.Start(new ProcessStartInfo("explorer.exe", drivePath) { UseShellExecute = true });

            // Otwieranie programu desktopowego
            string programPath = @"C:\Program Files (x86)\Microsoft Office\root\Office16\OUTLOOK.EXE"; //Microsoft Outlook
            Process.Start(new ProcessStartInfo(programPath) { UseShellExecute = true });

            // Dodanie opóźnienia 12 sekund (12000 milisekund)
            Thread.Sleep(12000);

            // Instalacja aplikacji desktopowej ze Sklepu Microsoft
            string appPackage = "Microsoft.Todos_8wekyb3d8bbwe!App"; // Zastąp "Microsoft.YourApp_8wekyb3d8bbwe!App" odpowiednim PackageFamilyName i AppID
            Process.Start(new ProcessStartInfo("explorer.exe", $"shell:AppsFolder\\{appPackage}") { UseShellExecute = true });

            // Dodanie opóźnienia 8 sekund (8000 milisekund)
            Thread.Sleep(8000);

            // Otwieranie aplikacji webowych, ścieżka do Chrome Proxy i parametry
            string chromeProxyPath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome_proxy.exe";
            string profileDirectory = "--profile-directory=\"Profile 3\"";
            // Otwieranie zarabiajtyleilechcesz.pl
            string appId1 = "--app-id=femkhbenfobnlelheeafglgnpbpfeejk";
            Process.Start(new ProcessStartInfo(chromeProxyPath, $"{profileDirectory} {appId1}") { UseShellExecute = true });
            // Otwieranie Dun & Bradstreet
            string appId2 = "--app-id=ddigokhlodmfdnihjnknlmkihblieiga";
            Process.Start(new ProcessStartInfo(chromeProxyPath, $"{profileDirectory} {appId2}") { UseShellExecute = true });
            // Otwieranie Kalendarz Google
            string appId3 = "--app-id=kjbdgfilnfhdoflbpgamdcdgpehopbep";
            Process.Start(new ProcessStartInfo(chromeProxyPath, $"{profileDirectory} {appId3}") { UseShellExecute = true });

            // Ścieżka do klasycznej aplikacji Excel
            string excelAppPath = @"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE"; // Upewnij się, że ścieżka jest poprawna
            // Link do pliku w OneDrive
            string excelFilePath = @"https://d.docs.live.net/27187f2dd9885da3/PROBET/PROBET%20baza.xlsx"; // Zmień na właściwą ścieżkę do pliku
            // Otwieranie pliku Excel w klasycznej aplikacji Excel
            Process.Start(new ProcessStartInfo(excelAppPath, excelFilePath) { UseShellExecute = true });

            // Konsola zamyka się automatycznie
            Environment.Exit(0);
        }
    }
}