using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingChess
{
    class Action
    {
        public void Put(Game game, Player player, ChessPieceType type, int x, int y)
        {
            Board board = game.getBoard();
            GameType gameType = game.getGameType();
            Position[][] positions = board.getPosition();
            if (gameType == GameType.CHESS)
            {
                if (x < 0 || x > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y < 0 || y > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x][y].getPiece() != null)
                {
                    Console.WriteLine("error.");
                    return;
                }
                ChessPiece chessPiece = new ChessPiece();
                chessPiece.setBelong(player);
                chessPiece.setType(type);
                positions[x][y].setPiece(chessPiece);
            }
            else if (gameType == GameType.GO)
            {
                if (x < 0 || x > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y < 0 || y > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x][y].getPiece() != null)
                {
                    Console.WriteLine("error.");
                    return;
                }
                Piece piece = new Piece();
                piece.setBelong(player);
                positions[x][y].setPiece(piece);
            }
        }

        public void Move(Game game, Player player, int x1, int y1, int x2, int y2)
        {
            Board board = game.getBoard();
            GameType gameType = game.getGameType();
            Position[][] positions = board.getPosition();
            if (gameType == GameType.CHESS)
            {
                if (x1 < 0 || x1 > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y1 < 0 || y1 > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (x2 < 0 || x2 > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y2 < 0 || y2 > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (x1 == x2 && y1 == y2)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x1][y1].getPiece() == null)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x2][y2].getPiece() != null)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (!(positions[x1][y1].getPiece().getBelong().Equals(player)))
                {
                    Console.WriteLine("error.");
                    return;
                }

                positions[x2][y2].setPiece(positions[x1][y1].getPiece());
                positions[x1][y1].removePiece();
            }
            else if (gameType == GameType.GO)
            {
                if (x1 < 0 || x1 > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y1 < 0 || y1 > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (x2 < 0 || x2 > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y2 < 0 || y2 > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (x1 == x2 && y1 == y2)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x1][y1].getPiece() == null)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x2][y2].getPiece() != null)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (!(positions[x1][y1].getPiece().getBelong().Equals(player)))
                {
                    Console.WriteLine("error.");
                    return;
                }

                positions[x2][y2].setPiece(positions[x1][y1].getPiece());
                positions[x1][y1].removePiece();
            }
        }

        public void RemoveGo(Game game, Player player, int x, int y)
        {
            Board board = game.getBoard();
            Position[][] positions = board.getPosition();

            if (x < 0 || x > 18)
            {
                Console.WriteLine("error.");
                return;
            }
            if (y < 0 || y > 18)
            {
                Console.WriteLine("error.");
                return;
            }
            if (positions[x][y].getPiece() == null)
            {
                Console.WriteLine("error.");
                return;
            }
            if (positions[x][y].getPiece().getBelong().Equals(player))
            {
                Console.WriteLine("error.");
                return;
            }
            positions[x][y].removePiece();
        }

        public void RemoveChess(Game game, Player player, int x1, int y1, int x2, int y2)
        {
            Board board = game.getBoard();
            Position[][] positions = board.getPosition();

            if (x1 < 0 || x1 > 7)
            {
                Console.WriteLine("error.");
                return;
            }
            if (y1 < 0 || y1 > 7)
            {
                Console.WriteLine("error.");
                return;
            }
            if (x2 < 0 || x2 > 7)
            {
                Console.WriteLine("error.");
                return;
            }
            if (y2 < 0 || y2 > 7)
            {
                Console.WriteLine("error.");
                return;
            }

            if (positions[x1][y1].getPiece() == null)
            {
                Console.WriteLine("error.");
                return;
            }
            if (positions[x2][y2].getPiece() == null)
            {
                Console.WriteLine("error.");
                return;
            }
            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("error.");
                return;
            }
            if (!(positions[x1][y1].getPiece().getBelong().Equals(player)))
            {
                Console.WriteLine("error.");
                return;
            }
            if (positions[x2][y2].getPiece().getBelong().Equals(player))
            {
                Console.WriteLine("error.");
                return;
            }
            positions[x2][y2].setPiece(positions[x1][y1].getPiece());
            positions[x1][y1].removePiece();
        }

        public void Look(Game game, int x, int y)
        {
            Board board = game.getBoard();
            GameType gameType = game.getGameType();
            Position[][] positions = board.getPosition();

            if (gameType == GameType.CHESS)
            {
                if (x < 0 || x > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y < 0 || y > 7)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x][y].getPiece() == null)
                {
                    Console.WriteLine("No piece.");
                    return;
                }
                if (positions[x][y].getPiece().getBelong().Equals(game.getPlayer1()))
                {
                    ChessPiece chessPiece = (ChessPiece)(positions[x][y].getPiece());
                    switch (chessPiece.getType())
                    {
                        case ChessPieceType.KING:
                            Console.WriteLine("Player1 KING.");
                            break;
                        case ChessPieceType.QUEEN:
                            Console.WriteLine("Player1 QUEEN.");
                            break;
                        case ChessPieceType.ROCK:
                            Console.WriteLine("Player1 ROCK.");
                            break;
                        case ChessPieceType.BISHOP:
                            Console.WriteLine("Player1 BISHOP.");
                            break;
                        case ChessPieceType.KNIGHT:
                            Console.WriteLine("Player1 KNIGHT.");
                            break;
                        case ChessPieceType.PAWN:
                            Console.WriteLine("Player1 PAWN.");
                            break;
                    }
                }
                else if (positions[x][y].getPiece().getBelong().Equals(game.getPlayer2()))
                {
                    ChessPiece chessPiece = (ChessPiece)(positions[x][y].getPiece());
                    switch (chessPiece.getType())
                    {
                        case ChessPieceType.KING:
                            Console.WriteLine("Player2 KING.");
                            break;
                        case ChessPieceType.QUEEN:
                            Console.WriteLine("Player2 QUEEN");
                            break;
                        case ChessPieceType.ROCK:
                            Console.WriteLine("Player2 ROCK");
                            break;
                        case ChessPieceType.BISHOP:
                            Console.WriteLine("Player2 BISHOP");
                            break;
                        case ChessPieceType.KNIGHT:
                            Console.WriteLine("Player2 KNIGHT");
                            break;
                        case ChessPieceType.PAWN:
                            Console.WriteLine("Player2 PAWN");
                            break;
                    }
                }
            }
            else if (gameType == GameType.GO)
            {
                if (x < 0 || x > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (y < 0 || y > 18)
                {
                    Console.WriteLine("error.");
                    return;
                }
                if (positions[x][y].getPiece() == null)
                {
                    Console.WriteLine("No piece.");
                    return;
                }
                if (positions[x][y].getPiece().getBelong().Equals(game.getPlayer1()))
                {
                    Console.WriteLine("Player1");
                }
                else if (positions[x][y].getPiece().getBelong().Equals(game.getPlayer2()))
                {
                    Console.WriteLine("Player2");
                }
            }
        }

        public void Count(Game game)
        {
            Board board = game.getBoard();
            GameType gameType = game.getGameType();
            Position[][] positions = board.getPosition();

            int player1Count = 0;
            int player2Count = 0;

            if (gameType == GameType.CHESS)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (positions[i][j].getPiece() == null)
                        {
                            continue;
                        }
                        if (positions[i][j].getPiece().getBelong().Equals(game.getPlayer1()))
                        {
                            player1Count++;
                        }
                        if (positions[i][j].getPiece().getBelong().Equals(game.getPlayer2()))
                        {
                            player2Count++;
                        }
                    }
                }
            }
            else if (gameType == GameType.GO)
            {
                for (int i = 0; i < 19; i++)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        if (positions[i][j].getPiece() == null)
                        {
                            continue;
                        }
                        if (positions[i][j].getPiece().getBelong().Equals(game.getPlayer1()))
                        {
                            player1Count++;
                        }
                        if (positions[i][j].getPiece().getBelong().Equals(game.getPlayer2()))
                        {
                            player2Count++;
                        }
                    }
                }
            }
            Console.WriteLine("Player1:" + player1Count + ", Player2: " + player2Count + ".");
        }
    }
}
