using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public class character
{

  #region Aggregations


  #endregion

  #region Compositions


  #endregion

  #region Attributes

  /// <summary>
  /// 
  /// </summary>
  protected int health
  {
    get
    {
      return m_health;
    }
    set
    {
      m_health = value;
    }
  }
  private int m_health;


  /// <summary>
  /// 
  /// </summary>
  protected int mana
  {
    get
    {
      return m_mana;
    }
    set
    {
      m_mana = value;
    }
  }
  private int m_mana;


  /// <summary>
  /// 
  /// </summary>
  protected int strength
  {
    get
    {
      return m_strength;
    }
    set
    {
      m_strength = value;
    }
  }
  private int m_strength = 1;


  /// <summary>
  /// 
  /// </summary>
  protected char name
  {
    get
    {
      return m_name;
    }
    set
    {
      m_name = value;
    }
  }
  private char m_name;



  #endregion


  #region Public methods

  /// <summary>
  /// attribut les PV et les MP du joueur
  /// </summary>
  /// <param name="health"></param>
  /// <param name="mana"></param>
  /// <returns></returns>
  public void classBuilder(int health, int mana)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// nom du perso : message envoyés
  /// </summary>
  /// <param name="name"></param>
  /// <param name="message"></param>
  /// <returns></returns>
  public void chat(string name, string message)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// force aléatoire entre 1 et 10
  /// </summary>
  /// <param name="strength"></param>
  /// <returns></returns>
  public void attack(int strength)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// bloque si multiple de 3 = false sinon = true
  /// </summary>
  /// <param name="blocked"></param>
  /// <returns></returns>
  public void isBlock(bool blocked)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  #endregion


  #region Protected methods

  #endregion


  #region Private methods

  #endregion


}

