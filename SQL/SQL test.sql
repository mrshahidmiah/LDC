
-- Given the following tables, write a query which returns the total footfall count per premises. 
-- The resultset should contain the following non-null columns: 
--		Business, StreetNo, Street, PostCode, FootfallCount. 
-- Premises do not necessarily have footfall for every week (missing counts will have a count of zero). 
-- Missing street numbers will be replaced with empty string ''.  


SELECT biz.Business,
	   CASE WHEN prem.StreetNo IS NULL THEN '' ELSE prem.StreetNo END AS StreetNo,
	   prem.Street,
	   prem.PostCode,
	   SUM(f.Count) AS FootfallCount

FROM Businesses AS biz	
	JOIN Premises AS prem
		ON prem.BusinessId = biz.Id	
	JOIN Footfall AS f
		ON f.PremisesId = prem.Id
	
GROUP BY	biz.Business,
			prem.StreetNo,
			prem.Street,
			prem.PostCode

ORDER BY FootfallCount DESC	-- order by footfall (descending)
--ORDER BY b.Business	-- order by business (ascending)