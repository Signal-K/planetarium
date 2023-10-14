   using Supabase;
   using Supabase.Models;
   using UnityEngine;

   public class SupabaseManager : MonoBehaviour
   {
       private SupabaseClient supabaseClient;

       private async void Start()
       {
           // Replace 'your-supabase-url' and 'your-supabase-key' with your actual Supabase URL and API key
           supabaseClient = new SupabaseClient("your-supabase-url", "your-supabase-key");

           // Example: Insert a new message
           var message = new Message
           {
               Id = 1,
               UserName = "John",
               ChannelId = 123
           };
           var insertResponse = await supabaseClient
               .From<Message>()
               .Insert(message)
               .Execute();

           if (insertResponse.IsSuccessStatusCode)
           {
               Debug.Log("Message inserted successfully!");
           }
           else
           {
               Debug.LogError(insertResponse.Error);
           }

           // Example: Query messages
           var selectResponse = await supabaseClient
               .From<Message>()
               .Select("*")
               .Limit(10)
               .Execute();

           if (selectResponse.IsSuccessStatusCode)
           {
               var messages = selectResponse.Data;
               foreach (var msg in messages)
               {
                   Debug.Log($"Message: {msg.UserName} - Channel ID: {msg.ChannelId}");
               }
           }
           else
           {
               Debug.LogError(selectResponse.Error);
           }
       }
   }
