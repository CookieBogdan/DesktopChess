﻿

namespace Domain.Models.Figures
{
	public class Rook : Figure
	{
		public Rook(Cell sell, IFiguresPainter figuresPainter, FigureColor color = FigureColor.Black) : base(sell, figuresPainter, color)
		{

		}

		public override string Name => "Rook";

		public override List<Cell> GetAvaibleCells(Cell[,] boardSells, MoveRecord lastMove)
		{
			List<Cell> list = new List<Cell>();

			for (int i = -1; i <= 1; i+=2)
			{
				int x = CurrentCell.X + i;
				int y = CurrentCell.Y;
				while (CanMoveTo(x, y, boardSells))
				{
					list.Add(boardSells[x, y]);
					if (boardSells[x, y].Figure != null) break;
					x += i;
				}
			}	

			for (int i = -1; i <= 1; i+=2)
			{
				int x = CurrentCell.X;
				int y = CurrentCell.Y + i;
				while (CanMoveTo(x, y, boardSells))
				{
					list.Add(boardSells[x, y]);
					if (boardSells[x, y].Figure != null) break;
					y += i;
				}
			}

			return list;
		}
	}
}
