using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    static float paddleMoveUnitsPerSecond = 0.3f;
    static float ballImpulseForce = 200;
    static float ballSpeed = 5;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }

    public float BallSpeed
    {
        get { return ballSpeed; }
    }


    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        StreamReader stream = null;
        try
        {
            stream = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName));
            string names = stream.ReadLine();
            string values = stream.ReadLine();
            SetConfigurationDataFields(values);
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Exception While Reading Configuration File: " + ex.Message);
        }
        finally {
            if (stream != null)
            {
                stream.Close();
            }
        }
    }
    void SetConfigurationDataFields(string csvValues) {
        string[] values = csvValues.Split(',');
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballSpeed = float.Parse(values[2]);
    }

    #endregion
}
