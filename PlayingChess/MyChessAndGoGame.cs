using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingChess
{
    class MyChessAndGoGame
    {
        private static Game game;
        private static Action action;

        public static void main(String[] args)
        {
            game = new Game();
            action = new Action();
            Console.WriteLine("Please enter game type:");
            String gameType = Console.ReadLine();

            Console.WriteLine("Enter name for player 1:");
            String player1 = Console.ReadLine();
            game.setPlayer1(player1);
            Console.WriteLine("Enter name for player 2:");
            String player2 = Console.ReadLine();
            game.setPlayer2(player2);

            if (gameType.Equals("chess"))
            {
                game.setGameType(GameType.CHESS);
            }
            else if (gameType.Equals("go"))
            {
                game.setGameType(GameType.GO);
            }

        MAINLOOP:
            while (true)
            {
                Console.WriteLine("Player1:");
                String move1str = Console.ReadLine();
                String[] move1 = move1str.Split(' ');

                switch (move1[0])
                {
                    case "put":
                        if (game.getGameType() == GameType.CHESS)
                        {
                            if (move1.Length != 4)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            int x5;
                            int y5;
                            try
                            {
                                x5 = Convert.ToInt32(move1[2]);
                                y5 = Convert.ToInt32(move1[3]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            switch (move1[1])
                            {
                                case "KING":
                                    action.Put(game, game.getPlayer1(), ChessPieceType.KING, x5, y5);
                                    game.getPlayer1().RecordStep("put KING at (" + x5 + "," + y5 + ").");
                                    break;
                                case "QUEEN":
                                    action.Put(game, game.getPlayer1(), ChessPieceType.QUEEN, x5, y5);
                                    game.getPlayer1().RecordStep("put QUEEN at (" + x5 + "," + y5 + ").");
                                    break;
                                case "ROCK":
                                    action.Put(game, game.getPlayer1(), ChessPieceType.ROCK, x5, y5);
                                    game.getPlayer1().RecordStep("put ROCK at (" + x5 + "," + y5 + ").");
                                    break;
                                case "BISHOP":
                                    action.Put(game, game.getPlayer1(), ChessPieceType.BISHOP, x5, y5);
                                    game.getPlayer1().RecordStep("put BISHOP at (" + x5 + "," + y5 + ").");
                                    break;
                                case "KNIGHT":
                                    action.Put(game, game.getPlayer1(), ChessPieceType.KNIGHT, x5, y5);
                                    game.getPlayer1().RecordStep("put KNIGHT at (" + x5 + "," + y5 + ").");
                                    break;
                                case "PAWN":
                                    action.Put(game, game.getPlayer1(), ChessPieceType.PAWN, x5, y5);
                                    game.getPlayer1().RecordStep("put PAWN at (" + x5 + "," + y5 + ").");
                                    break;
                                default:
                                    Console.WriteLine("error.");
                                    break;
                            }
                        }
                        else if (game.getGameType() == GameType.GO)
                        {
                            if (move1.Length != 3)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            int x3;
                            int y3;
                            try
                            {
                                x3 = Convert.ToInt32(move1[1]);
                                y3 = Convert.ToInt32(move1[2]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            action.Put(game, game.getPlayer1(), ChessPieceType.OTHER, x3, y3);
                            game.getPlayer1().RecordStep("put at (" + x3 + "," + y3 + ").");
                        }
                        break;
                    case "move":
                        if (game.getGameType() == GameType.GO)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        if (move1.Length != 5)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        int x1;
                        int y1;
                        int x2;
                        int y2;
                        try
                        {
                            x1 = Convert.ToInt32(move1[1]);
                            y1 = Convert.ToInt32(move1[2]);
                            x2 = Convert.ToInt32(move1[3]);
                            y2 = Convert.ToInt32(move1[4]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        action.Move(game, game.getPlayer1(), x1, y1, x2, y2);
                        game.getPlayer1().RecordStep("move from (" + x1 + "," + y1 + ") to (" + x2 + "," + y2 + ").");
                        break;

                    case "remove":
                        if (game.getGameType() == GameType.CHESS)
                        {
                            if (move1.Length != 5)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            try
                            {
                                x1 = Convert.ToInt32(move1[1]);
                                y1 = Convert.ToInt32(move1[2]);
                                x2 = Convert.ToInt32(move1[3]);
                                y2 = Convert.ToInt32(move1[4]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            action.RemoveChess(game, game.getPlayer1(), x1, y1, x2, y2);
                            game.getPlayer1().RecordStep("use (" + x1 + "," + y1 + ") to replace (" + x2 + "," + y2 + ").");
                        }
                        else if (game.getGameType() == GameType.GO)
                        {
                            if (move1.Length != 3)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            int x4;
                            int y4;
                            try
                            {
                                x4 = Convert.ToInt32(move1[1]);
                                y4 = Convert.ToInt32(move1[2]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            action.RemoveGo(game, game.getPlayer1(), x4, y4);
                            game.getPlayer1().RecordStep("remove(" + x4 + "," + y4 + ").");
                        }
                        break;
                    case "look":
                        if (move1.Length != 3)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        int x;
                        int y;
                        try
                        {
                            x = Convert.ToInt32(move1[1]);
                            y = Convert.ToInt32(move1[2]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        action.Look(game, x, y);
                        game.getPlayer1().RecordStep("look (" + x + "," + y + ").");
                        break;
                    case "count":
                        action.Count(game);
                        game.getPlayer1().RecordStep("count the pieces.");
                        break;
                    case "end":
                        game.getPlayer1().RecordStep("stop the game.");
                        goto EXIT;
                    case "pass":
                        game.getPlayer1().RecordStep("give up.");
                        break;
                    default:
                        Console.WriteLine("error.");
                        break;
                }


                Console.WriteLine("Player2:");
                String move2str = Console.ReadLine();

                String[] move2 = move2str.Split(' ');

                switch (move2[0])
                {
                    case "put":
                        if (game.getGameType() == GameType.CHESS)
                        {
                            if (move2.Length != 4)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            int x5;
                            int y5;
                            try
                            {
                                x5 = Convert.ToInt32(move2[2]);
                                y5 = Convert.ToInt32(move2[3]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            switch (move2[1])
                            {
                                case "KING":
                                    action.Put(game, game.getPlayer2(), ChessPieceType.KING, x5, y5);
                                    game.getPlayer2().RecordStep("put KING at (" + x5 + "," + y5 + ").");
                                    break;
                                case "QUEEN":
                                    action.Put(game, game.getPlayer2(), ChessPieceType.QUEEN, x5, y5);
                                    game.getPlayer2().RecordStep("put QUEEN at (" + x5 + "," + y5 + ").");
                                    break;
                                case "ROCK":
                                    action.Put(game, game.getPlayer2(), ChessPieceType.ROCK, x5, y5);
                                    game.getPlayer2().RecordStep("put ROCK at (" + x5 + "," + y5 + ").");
                                    break;
                                case "BISHOP":
                                    action.Put(game, game.getPlayer2(), ChessPieceType.BISHOP, x5, y5);
                                    game.getPlayer2().RecordStep("put BISHOP at (" + x5 + "," + y5 + ").");
                                    break;
                                case "KNIGHT":
                                    action.Put(game, game.getPlayer2(), ChessPieceType.KNIGHT, x5, y5);
                                    game.getPlayer2().RecordStep("put KNIGHT at (" + x5 + "," + y5 + ").");
                                    break;
                                case "PAWN":
                                    action.Put(game, game.getPlayer2(), ChessPieceType.PAWN, x5, y5);
                                    game.getPlayer2().RecordStep("put PAWN at (" + x5 + "," + y5 + ").");
                                    break;
                                default:
                                    Console.WriteLine("error.");
                                    break;
                            }
                        }
                        else if (game.getGameType() == GameType.GO)
                        {
                            if (move2.Length != 3)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            int x3;
                            int y3;
                            try
                            {
                                x3 = Convert.ToInt32(move2[1]);
                                y3 = Convert.ToInt32(move2[2]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            action.Put(game, game.getPlayer2(), ChessPieceType.OTHER, x3, y3);
                            game.getPlayer2().RecordStep("put at (" + x3 + "," + y3 + ").");
                        }
                        break;
                    case "move":
                        if (game.getGameType() == GameType.GO)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        if (move2.Length != 5)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        int x1;
                        int y1;
                        int x2;
                        int y2;
                        try
                        {
                            x1 = Convert.ToInt32(move2[1]);
                            y1 = Convert.ToInt32(move2[2]);
                            x2 = Convert.ToInt32(move2[3]);
                            y2 = Convert.ToInt32(move2[4]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        action.Move(game, game.getPlayer2(), x1, y1, x2, y2);
                        game.getPlayer2().RecordStep("move from (" + x1 + "," + y1 + ") to (" + x2 + "," + y2 + ").");
                        break;

                    case "remove":
                        if (game.getGameType() == GameType.CHESS)
                        {
                            if (move2.Length != 5)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            try
                            {
                                x1 = Convert.ToInt32(move2[1]);
                                y1 = Convert.ToInt32(move2[2]);
                                x2 = Convert.ToInt32(move2[3]);
                                y2 = Convert.ToInt32(move2[4]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            action.RemoveChess(game, game.getPlayer2(), x1, y1, x2, y2);
                            game.getPlayer2().RecordStep("use (" + x1 + "," + y1 + ") to replace (" + x2 + "," + y2 + ").");
                        }
                        else if (game.getGameType() == GameType.GO)
                        {
                            if (move2.Length != 3)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            int x4;
                            int y4;
                            try
                            {
                                x4 = Convert.ToInt32(move2[1]);
                                y4 = Convert.ToInt32(move2[2]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("error.");
                                break;
                            }
                            action.RemoveGo(game, game.getPlayer2(), x4, y4);
                            game.getPlayer2().RecordStep("remove (" + x4 + "," + y4 + ").");
                        }
                        break;
                    case "look":
                        if (move2.Length != 3)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        int x;
                        int y;
                        try
                        {
                            x = Convert.ToInt32(move2[1]);
                            y = Convert.ToInt32(move2[2]);
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("error.");
                            break;
                        }
                        action.Look(game, x, y);
                        game.getPlayer2().RecordStep("look (" + x + "," + y + ").");
                        break;
                    case "count":
                        action.Count(game);
                        game.getPlayer2().RecordStep("count the pieces.");
                        break;
                    case "end":
                        game.getPlayer2().RecordStep("stop the game.");
                        goto EXIT;
                    case "pass":
                        game.getPlayer2().RecordStep("give up.");
                        break;
                    default:
                        Console.WriteLine("error.");
                        break;
                }
            }
        EXIT:
            ArrayList player1Moves = game.getPlayer1().getMoves();
            ArrayList player2Moves = game.getPlayer2().getMoves();

            Console.WriteLine();
            Console.WriteLine("Game over!");
            Console.WriteLine();
            foreach (String s in player1Moves)
            {
                Console.WriteLine("Player1 " + s);
            }
            Console.WriteLine();
            foreach (String s in player2Moves)
            {
                Console.WriteLine("Player2 " + s);
            }
        }
    }
}
