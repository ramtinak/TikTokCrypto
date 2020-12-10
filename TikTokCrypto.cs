/*
 * A tiny class for XOR algorithm for TikTok.com
 * 
 * I've created this class a long time ago. Someone asked me how XOR works in C# for TikTok. Here this is how:
 * 
 * -------------------------------------------------------------------------------------------------------------
 * 
 * For example, ramtinak@live.com as value will generates: 776468716c6b646e45696c73602b666a68
 * 
 * -------------------------------------------------------------------------------------------------------------
 * 
 * Created by: Ramtin Jokar [ Ramtinak@live.com ] 
 * 
 * IRANIAN DEVELOPERS.
 * 
 */
using System;
using System.Linq;

public class TikTokCrypto
{
    public static string ConvertToXorText(string value)
    {
        const int key = 5; // tiktok only
        var t = value.Select(x => Convert.ToByte(x ^ key));
        return BitConverter.ToString(t.ToArray()).Replace("-", "").ToLower();
    }
}
