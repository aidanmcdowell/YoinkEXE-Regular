using System;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
	public class DiscordRpc
	{
		public DiscordRpc()
		{
		}

		[DllImport("discord-rpc-w32.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, EntryPoint="Discord_Initialize", ExactSpelling=false)]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		[DllImport("discord-rpc-w32.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, EntryPoint="Discord_RunCallbacks", ExactSpelling=false)]
		public static extern void RunCallbacks();

		[DllImport("discord-rpc-w32.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, EntryPoint="Discord_Shutdown", ExactSpelling=false)]
		public static extern void Shutdown();

		[DllImport("discord-rpc-w32.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, EntryPoint="Discord_UpdatePresence", ExactSpelling=false)]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		public struct EventHandlers
		{
			public DiscordRpc.ReadyCallback readyCallback;

			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			public DiscordRpc.ErrorCallback errorCallback;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		[Serializable]
		public struct RichPresence
		{
			public string state;

			public string details;

			public long startTimestamp;

			public long endTimestamp;

			public string largeImageKey;

			public string largeImageText;

			public string smallImageKey;

			public string smallImageText;

			public string partyId;

			public int partySize;

			public int partyMax;

			public string matchSecret;

			public string joinSecret;

			public string spectateSecret;

			public bool instance;
		}
	}
}