using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public class orc : character
{

  #region Aggregations


  #endregion

  #region Compositions


  #endregion

  #region Attributes


  #endregion


  #region Public methods

  /// <summary>
  /// 
  /// </summary>
  /// <param name="health"></param>
  /// <param name="mana"></param>
  /// <returns>character</returns>
  public orc(int health, int mana)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// permet l'envoi d'un message Nom du joueur : Message à envoyés
  /// </summary>
  /// <param name="name"></param>
  /// <param name="message"></param>
  /// <returns>chat</returns>
  public chat sendMessage(string name, string message)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// si != 3/6/9 ça donne true donc DMG sur ennemi
  /// </summary>
  /// <param name="strength"></param>
  /// <param name="isBlock"></param>
  /// <param name="health"></param>
  /// <returns>attack</returns>
  public attack kick(int strength, bool isBlock, int health)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  #endregion


  #region Protected methods

  #endregion


  #region Private methods

  #endregion


}

