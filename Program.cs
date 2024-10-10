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
     
            // Instalacja aplikacji desktopowej ze Sklepu Microsoft
            string appPackage = "Microsoft.Todos_8wekyb3d8bbwe!App"; // Zastąp "Microsoft.YourApp_8wekyb3d8bbwe!App" odpowiednim PackageFamilyName i AppID
            Process.Start(new ProcessStartInfo("explorer.exe", $"shell:AppsFolder\\{appPackage}") { UseShellExecute = true });

            // Ścieżka do Chrome Proxy i parametry
            string chromeProxyPath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome_proxy.exe";
            string profileDirectory = "--profile-directory=\"Profile 3\"";
            string appId = "--app-id=femkhbenfobnlelheeafglgnpbpfeejk"; //zarabiajtyleilechcesz.pl
            string appId2 = "--app-id=ddigokhlodmfdnihjnknlmkihblieiga"; //Dun & Bradstreet
            string appId3 = "--app-id=kjbdgfilnfhdoflbpgamdcdgpehopbe"; //Kalendarz Google
 
            // Otwieranie aplikacji webowych
            Process.Start(new ProcessStartInfo(chromeProxyPath, $"{profileDirectory} {appId}") { UseShellExecute = true });
            Process.Start(new ProcessStartInfo(chromeProxyPath, $"{profileDirectory} {appId2}") { UseShellExecute = true });
            Process.Start(new ProcessStartInfo(chromeProxyPath, $"{profileDirectory} {appId3}") { UseShellExecute = true });

            // Link do pliku w OneDrive
            string excelFileUrl = "https://d.docs.live.net/27187f2dd9885da3/PROBET/PROBET%20baza.xlsx";

            // Otwieranie pliku Excel z linku
            Process.Start(new ProcessStartInfo("cmd", $"/c start {excelFileUrl}") { UseShellExecute = true });

            // Konsola zamyka się automatycznie
            Environment.Exit(0);
        }
    }
}