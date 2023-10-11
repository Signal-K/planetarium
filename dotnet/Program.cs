using Supabase;

var url = "https://qwbufbmxkjfaikoloudl.supabase.co";
var key = "";

var options = new Supabase.SupabaseOptions {
    AutoConnectRealtime = true
};

var supabase = new Supabase.Client(url, key, options);
await supabase.InitializeAsync();