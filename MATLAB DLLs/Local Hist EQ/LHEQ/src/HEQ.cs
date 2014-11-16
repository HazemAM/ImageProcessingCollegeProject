/*
* MATLAB Compiler: 4.18 (R2012b)
* Date: Mon Nov 17 01:47:52 2014
* Arguments: "-B" "macro_default" "-W" "dotnet:LHEQ,HEQ,4.0,private" "-T" "link:lib" "-d"
* "D:\source Tree Gits\Image\MatLab Dlls\Local Hist EQ\LHEQ\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{HEQ:D:\Mat lab work space\LocalHE.m,D:\Mat lab work
* space\LocalStatistics.m,D:\source Tree Gits\Image\MATLAB Tasks\SSR.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace LHEQ
{

  /// <summary>
  /// The HEQ class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
  /// <newpara></newpara>
  /// D:\Mat lab work space\LocalHE.m
  /// <newpara></newpara>
  /// D:\Mat lab work space\LocalStatistics.m
  /// <newpara></newpara>
  /// D:\source Tree Gits\Image\MATLAB Tasks\SSR.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class HEQ : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static HEQ()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "LHEQ.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the HEQ class.
    /// </summary>
    public HEQ()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~HEQ()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the LocalHE M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// seperate each color channel (R, G, B) in TmpBuf and process it
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalHE()
    {
      return mcr.EvaluateFunction("LocalHE", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the LocalHE M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// seperate each color channel (R, G, B) in TmpBuf and process it
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalHE(MWArray Old)
    {
      return mcr.EvaluateFunction("LocalHE", Old);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the LocalHE M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// seperate each color channel (R, G, B) in TmpBuf and process it
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <param name="WinSize">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalHE(MWArray Old, MWArray WinSize)
    {
      return mcr.EvaluateFunction("LocalHE", Old, WinSize);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the LocalHE M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// seperate each color channel (R, G, B) in TmpBuf and process it
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalHE(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalHE", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the LocalHE M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// seperate each color channel (R, G, B) in TmpBuf and process it
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalHE(int numArgsOut, MWArray Old)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalHE", Old);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the LocalHE M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// seperate each color channel (R, G, B) in TmpBuf and process it
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <param name="WinSize">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalHE(int numArgsOut, MWArray Old, MWArray WinSize)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalHE", Old, WinSize);
    }


    /// <summary>
    /// Provides an interface for the LocalHE function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// seperate each color channel (R, G, B) in TmpBuf and process it
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void LocalHE(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("LocalHE", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalStatistics()
    {
      return mcr.EvaluateFunction("LocalStatistics", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalStatistics(MWArray Old)
    {
      return mcr.EvaluateFunction("LocalStatistics", Old);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalStatistics(MWArray Old, MWArray winSize)
    {
      return mcr.EvaluateFunction("LocalStatistics", Old, winSize);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalStatistics(MWArray Old, MWArray winSize, MWArray E)
    {
      return mcr.EvaluateFunction("LocalStatistics", Old, winSize, E);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <param name="K0">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalStatistics(MWArray Old, MWArray winSize, MWArray E, MWArray K0)
    {
      return mcr.EvaluateFunction("LocalStatistics", Old, winSize, E, K0);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <param name="K0">Input argument #4</param>
    /// <param name="K1">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalStatistics(MWArray Old, MWArray winSize, MWArray E, MWArray K0, 
                             MWArray K1)
    {
      return mcr.EvaluateFunction("LocalStatistics", Old, winSize, E, K0, K1);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <param name="K0">Input argument #4</param>
    /// <param name="K1">Input argument #5</param>
    /// <param name="K2">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray LocalStatistics(MWArray Old, MWArray winSize, MWArray E, MWArray K0, 
                             MWArray K1, MWArray K2)
    {
      return mcr.EvaluateFunction("LocalStatistics", Old, winSize, E, K0, K1, K2);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalStatistics(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalStatistics", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalStatistics(int numArgsOut, MWArray Old)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalStatistics", Old);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalStatistics(int numArgsOut, MWArray Old, MWArray winSize)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalStatistics", Old, winSize);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalStatistics(int numArgsOut, MWArray Old, MWArray winSize, 
                               MWArray E)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalStatistics", Old, winSize, E);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <param name="K0">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalStatistics(int numArgsOut, MWArray Old, MWArray winSize, 
                               MWArray E, MWArray K0)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalStatistics", Old, winSize, E, K0);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <param name="K0">Input argument #4</param>
    /// <param name="K1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalStatistics(int numArgsOut, MWArray Old, MWArray winSize, 
                               MWArray E, MWArray K0, MWArray K1)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalStatistics", Old, winSize, E, K0, K1);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the LocalStatistics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Old">Input argument #1</param>
    /// <param name="winSize">Input argument #2</param>
    /// <param name="E">Input argument #3</param>
    /// <param name="K0">Input argument #4</param>
    /// <param name="K1">Input argument #5</param>
    /// <param name="K2">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] LocalStatistics(int numArgsOut, MWArray Old, MWArray winSize, 
                               MWArray E, MWArray K0, MWArray K1, MWArray K2)
    {
      return mcr.EvaluateFunction(numArgsOut, "LocalStatistics", Old, winSize, E, K0, K1, K2);
    }


    /// <summary>
    /// Provides an interface for the LocalStatistics function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Process the image in CONVOLUTION manner
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void LocalStatistics(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("LocalStatistics", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the SSR M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SSR Single Scale Retinex
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SSR()
    {
      return mcr.EvaluateFunction("SSR", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the SSR M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SSR Single Scale Retinex
    /// </remarks>
    /// <param name="image">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SSR(MWArray image)
    {
      return mcr.EvaluateFunction("SSR", image);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the SSR M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SSR Single Scale Retinex
    /// </remarks>
    /// <param name="image">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SSR(MWArray image, MWArray sigma)
    {
      return mcr.EvaluateFunction("SSR", image, sigma);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the SSR M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SSR Single Scale Retinex
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SSR(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "SSR", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the SSR M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SSR Single Scale Retinex
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="image">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SSR(int numArgsOut, MWArray image)
    {
      return mcr.EvaluateFunction(numArgsOut, "SSR", image);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the SSR M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SSR Single Scale Retinex
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="image">Input argument #1</param>
    /// <param name="sigma">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SSR(int numArgsOut, MWArray image, MWArray sigma)
    {
      return mcr.EvaluateFunction(numArgsOut, "SSR", image, sigma);
    }


    /// <summary>
    /// Provides an interface for the SSR function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// SSR Single Scale Retinex
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void SSR(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("SSR", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
